using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Ray2Mod.Components.Types;
using Ray2Mod.Game.Structs.SPO;

namespace R2ObjView
{
    public unsafe class ObjectTreeManager
    {
        private Dictionary<string, ObjectNode> objectNodeMap = new Dictionary<string, ObjectNode>();

        public ObjectTreeManager()
        {
        }

        public delegate Acp.XHIE_tdfnEnumSpoCallback GetCallbackDelegate(TreeNode parentNode);

        public void Clear()
        {
            objectNodeMap.Clear();
        }

        public void InitIcons(TreeView tree)
        {
            tree.ImageList = IconManager.Icons;
        }

        public TreeNode NewTreeNode(string text, IconId iconId, SuperObject* tag = null)
        {
            TreeNode node = new TreeNode(text, (int)iconId, (int)iconId);
            node.Name = text;
            node.Tag = tag == null ? null : (Pointer<SuperObject>)tag;

            return node;
        }

        public void InvalidateAll()
        {
            foreach (KeyValuePair<string, ObjectNode> kv in objectNodeMap)
            {
                kv.Value.Invalidated = true;
            }
        }

        public void RemoveInvalidated(bool isGrouped = false)
        {
            KeyValuePair<string, ObjectNode>[] toRemove = objectNodeMap.Where(kv => kv.Value.Invalidated).ToArray();
            foreach (KeyValuePair<string, ObjectNode> kv in toRemove)
            {
                // delete invalidated nodes from treeview and node map
                if (isGrouped)
                    RemoveAndCleanUpGroups(kv.Value.Node);
                else
                    kv.Value.Node.Remove();

                objectNodeMap.Remove(kv.Key);
            }
        }

        private void RemoveAndCleanUpGroups(TreeNode node)
        {
            TreeNode currentModel = node.Parent;
            TreeNode currentFamily = currentModel.Parent;

            node.Remove();

            // remove model and/or family if they're empty

            if (currentModel.Nodes.Count == 0)
            {
                currentModel.Remove();

                if (currentFamily.Nodes.Count == 0)
                {
                    currentFamily.Remove();
                }
            }
        }

        public GetCallbackDelegate GetEnumCallback(bool isGrouped)
        {
            return isGrouped ? (GetCallbackDelegate)GetEnumGroupedSpoCallback : GetEnumNonGroupedSpoCallback;
        }

        public Acp.XHIE_tdfnEnumSpoCallback GetEnumGroupedSpoCallback(TreeNode parentNode)
        {
            return spo =>
            {
                string familyName = Acp.XHIE_fn_szGetObjectName(spo, Acp.XHIE_OI_TYPE.TOI_FAMILY) ??
                                    $"{spo->type} [{(int)spo:X8}]";
                string modelName = Acp.XHIE_fn_szGetObjectName(spo, Acp.XHIE_OI_TYPE.TOI_MODEL) ??
                                   $"{spo->type} [{(int)spo:X8}]";
                string spoName = Acp.XHIE_fn_szGetObjectName(spo, Acp.XHIE_OI_TYPE.TOI_INSTANCE) ??
                                 $"{spo->type} [{(int)spo:X8}]";

                ObjectNode objNode = null;

                if (objectNodeMap.TryGetValue(spoName, out objNode))
                {
                    objNode.Invalidated = false;
                    // update reference just in case
                    objNode.SuperObject = spo;
                    objNode.Node.Tag = (Pointer<SuperObject>)spo;

                    if (objNode.ParentNode != parentNode)
                    {
                        RemoveAndCleanUpGroups(objNode.Node);
                        objNode.ParentNode = parentNode;
                    }
                    else
                    {
                        // parent the same, can safely skip readding groups
                        return true;
                    }
                }
                else
                {
                    TreeNode node = NewTreeNode(spoName, IconId.Instance, spo);
                    objNode = new ObjectNode(spo, node, parentNode);
                    objectNodeMap[spoName] = objNode;
                }

                TreeNode familyNode = parentNode.Nodes[familyName];
                if (familyNode == null)
                {
                    familyNode = NewTreeNode(familyName, IconId.Family);
                    parentNode.Nodes.Add(familyNode);
                }

                TreeNode modelNode = familyNode.Nodes[modelName];
                if (modelNode == null)
                {
                    modelNode = NewTreeNode(modelName, IconId.Model);
                    familyNode.Nodes.Add(modelNode);
                }
                
                modelNode.Nodes.Add(objNode.Node);

                return true;
            };
        }

        public Acp.XHIE_tdfnEnumSpoCallback GetEnumNonGroupedSpoCallback(TreeNode parentNode)
        {
            return spo =>
            {
                string spoName = Acp.XHIE_fn_szGetObjectName(spo, Acp.XHIE_OI_TYPE.TOI_INSTANCE) ??
                                 $"{spo->type} [{(int)spo:X8}]";

                if (objectNodeMap.TryGetValue(spoName, out ObjectNode objNode))
                {
                    if (objNode.ParentNode != parentNode)
                    {
                        objNode.Node.Remove();
                        parentNode.Nodes.Add(objNode.Node);
                        objNode.ParentNode = parentNode;
                    }

                    // update reference just in case
                    objNode.SuperObject = spo;
                    objNode.Node.Tag = (Pointer<SuperObject>)spo;
                    objNode.Invalidated = false;
                }
                else
                {
                    TreeNode node = NewTreeNode(spoName, IconId.Spo, spo);
                    parentNode.Nodes.Add(node);
                    objectNodeMap[spoName] = new ObjectNode(spo, node, parentNode);
                }
                return true;
            };
        }

        public bool ShowSpoDetails(TreeNode node)
        {
            if (node.Tag is Pointer<SuperObject> spo)
            {
                SpoForm form = new SpoForm(spo);
                MainFrame.Instance.ShowChild(form);

                return true;
            }

            return false;
        }
    }
}