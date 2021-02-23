using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Ray2Mod.Components.Types;
using Ray2Mod.Game;
using Ray2Mod.Game.Structs;
using Ray2Mod.Game.Structs.SPO;

namespace R2ObjView
{
    public unsafe partial class WorldForm : Form, IChildFrame
    {
        private TreeNode activeWorld;
        private TreeNode inactiveWorld;
        private TreeNode fatherSector;

        public IMainFrame MainFrame { get; set; }
        public string ChildStatusText { get; private set; }
        public ToolStrip ChildToolStrip => toolStrip;

        private bool GroupSpo => fmiToolStripButton.Checked;

        private Dictionary<string, ObjectNode> objectNodeMap = new Dictionary<string, ObjectNode>();

        public WorldForm(IMainFrame mainFrame)
        {
            MainFrame = mainFrame;

            InitializeComponent();
            Icon = Resources.IconWorld;
            worldTree.ImageList = IconManager.Icons;

            InitWorldTree();
        }

        private delegate Acp.XHIE_tdfnEnumSpoCallback GetCallbackDelegate(TreeNode parentNode);

        private void InitWorldTree()
        {
            worldTree.Nodes.Clear();
            objectNodeMap.Clear();

            activeWorld = NewNode("Active Dynamic World", IconId.World);
            inactiveWorld = NewNode("Inactive Dynamic World", IconId.World);
            fatherSector = NewNode("Father Sector", IconId.World);

            worldTree.Nodes.Add(activeWorld);
            worldTree.Nodes.Add(inactiveWorld);
            worldTree.Nodes.Add(fatherSector);

            UpdateWorldTree();
        }

        private void UpdateWorldTree()
        {
            // TODO: remove empty families and models on level change
            // just check level name or something

            foreach (KeyValuePair<string, ObjectNode> kv in objectNodeMap)
            {
                kv.Value.Invalidated = true;
            }

            GetCallbackDelegate getCallbackMethod =
                GroupSpo ? (GetCallbackDelegate)GetEnumGroupedSpoCallback : GetEnumNonGroupedSpoCallback;

            int nActive = Acp.XHIE_fn_lEnumSpoChildren(*(SuperObject**)Offsets.ActiveDynamicWorld,
                getCallbackMethod(activeWorld));
            int nInactive = Acp.XHIE_fn_lEnumSpoChildren(*(SuperObject**)Offsets.InactiveDynamicWorld,
                getCallbackMethod(inactiveWorld));
            int nSectors = Acp.XHIE_fn_lEnumSpoChildren(*(SuperObject**)Offsets.FatherSector, EnumSectorCallback);

            foreach (KeyValuePair<string, ObjectNode> kv in objectNodeMap)
            {
                if (kv.Value.Invalidated)
                {
                    kv.Value.Node.Remove();
                }
            }

            ChildStatusText = $"Active: {nActive} objects, Inactive: {nInactive} objects, Sectors: {nSectors} objects.";
            MainFrame.SetStatus(this, ChildStatusText);
        }

        private Acp.XHIE_tdfnEnumSpoCallback GetEnumGroupedSpoCallback(TreeNode parentNode)
        {
            return spo =>
            {
                string familyName = Acp.XHIE_fn_szGetObjectName(spo, Acp.XHIE_OI_TYPE.TOI_FAMILY) ??
                                    $"Unknown [{(int)spo:X8}]";
                string modelName = Acp.XHIE_fn_szGetObjectName(spo, Acp.XHIE_OI_TYPE.TOI_MODEL) ??
                                   $"Unknown [{(int)spo:X8}]";
                string spoName = Acp.XHIE_fn_szGetObjectName(spo, Acp.XHIE_OI_TYPE.TOI_INSTANCE) ??
                                 $"Unknown [{(int)spo:X8}]";


                if (objectNodeMap.TryGetValue(spoName, out ObjectNode objNode))
                {
                    if (objNode.ParentNode != parentNode)
                    {
                        objNode.Node.Remove();
                    }
                    else
                    {
                        objNode.Invalidated = false;
                        return;
                    }
                }

                TreeNode familyNode = parentNode.Nodes[familyName];
                if (familyNode == null)
                {
                    familyNode = NewNode(familyName, IconId.Family);
                    parentNode.Nodes.Add(familyNode);
                }

                TreeNode modelNode = familyNode.Nodes[modelName];
                if (modelNode == null)
                {
                    modelNode = NewNode(modelName, IconId.Model);
                    familyNode.Nodes.Add(modelNode);
                }

                TreeNode node = NewNode(spoName, IconId.Instance, (Pointer<SuperObject>)spo);
                modelNode.Nodes.Add(node);
                objectNodeMap[spoName] = new ObjectNode(spo, node, parentNode);
            };
        }

        private Acp.XHIE_tdfnEnumSpoCallback GetEnumNonGroupedSpoCallback(TreeNode parentNode)
        {
            return spo =>
            {
                string spoName = Acp.XHIE_fn_szGetObjectName(spo, Acp.XHIE_OI_TYPE.TOI_INSTANCE) ??
                                 $"Unknown [{(int)spo:X8}]";

                if (objectNodeMap.TryGetValue(spoName, out ObjectNode objNode))
                {
                    if (objNode.ParentNode != parentNode)
                    {
                        objNode.Node.Remove();
                        parentNode.Nodes.Add(objNode.Node);
                    }

                    objNode.Invalidated = false;
                    return;
                }

                TreeNode node = NewNode(spoName, IconId.Spo, (Pointer<SuperObject>)spo);
                parentNode.Nodes.Add(node);
                objectNodeMap[spoName] = new ObjectNode(spo, node, parentNode);
            };
        }

        private void EnumSectorCallback(SuperObject* spo)
        {
            string spoName = $"Sector [{(int)spo:X8}]";

            if (objectNodeMap.TryGetValue(spoName, out ObjectNode objNode))
            {
                objNode.Invalidated = false;
                return;
            }

            TreeNode node = NewNode(spoName, IconId.Spo, (Pointer<SuperObject>)spo);
            fatherSector.Nodes.Add(node);
            objectNodeMap[spoName] = new ObjectNode(spo, node, fatherSector);
        }

        private TreeNode NewNode(string text, IconId iconId, object tag = null)
        {
            return new TreeNode(text, (int)iconId, (int)iconId) { Tag = tag, Name = text };
        }

        private void fmiToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            InitWorldTree();
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            UpdateWorldTree();
        }

        private void spoToolStripButton_Click(object sender, EventArgs e)
        {
            TreeNode node = worldTree.SelectedNode;

            if (node.Tag is Pointer<SuperObject> spo)
            {
                Acp.AI_fn_lEnumSpoDsgVars(spo, (type, value, initialValue) =>
                {
                    string sValue = "";
                    string sInitValue = "";

                    switch (type)
                    {
                        case DsgVarType.Boolean:
                            sValue = ((bool*)value)->ToString();
                            sInitValue = ((bool*)initialValue)->ToString();
                            break;
                        case DsgVarType.Byte:
                            sValue = ((sbyte*)value)->ToString();
                            sInitValue = ((sbyte*)initialValue)->ToString();
                            break;
                        case DsgVarType.UByte:
                            sValue = ((byte*)value)->ToString();
                            sInitValue = ((byte*)initialValue)->ToString();
                            break;
                        case DsgVarType.Short:
                            sValue = ((short*)value)->ToString();
                            sInitValue = ((short*)initialValue)->ToString();
                            break;
                        case DsgVarType.UShort:
                            sValue = ((ushort*)value)->ToString();
                            sInitValue = ((ushort*)initialValue)->ToString();
                            break;
                        case DsgVarType.Int:
                            sValue = ((int*)value)->ToString();
                            sInitValue = ((int*)initialValue)->ToString();
                            break;
                        case DsgVarType.UInt:
                            sValue = ((uint*)value)->ToString();
                            sInitValue = ((uint*)initialValue)->ToString();
                            break;
                        case DsgVarType.Float:
                            sValue = ((float*)value)->ToString();
                            sInitValue = ((float*)initialValue)->ToString();
                            break;
                        case DsgVarType.SuperObject:
                            sValue = $"{*(int*)value:X8}";
                            sInitValue = $"{*(int*)initialValue:X8}";
                            break;
                    }

                    // TODO: superobject details form
                    Debug.WriteLine($"Type: {type}, Value: {sValue}, InitValue: {sInitValue}");
                });
            }
        }
    }
}