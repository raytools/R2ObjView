using System;
using System.Windows.Forms;
using Ray2Mod.Components.Types;
using Ray2Mod.Game.Structs.Dynamics;
using Ray2Mod.Game.Structs.Dynamics.Blocks;
using Ray2Mod.Game.Structs.SPO;

namespace R2ObjView.SPO
{
    public unsafe class DynamManager
    {
        public DynamicsBlockBase.DynamicsType DynamType =>
            SuperObject.StructPtr->PersoData->dynam->DynamicsBase->DynamicsBlockBase.Type;

        private Pointer<SuperObject> SuperObject { get; }

        private ListViewItem base_ObjectType = InitListItem("Object Type");
        private ListViewItem base_CurrentIdCard = InitListItem("Current ID Card");
        private ListViewItem base_Flags = InitListItem("Flags");
        private ListViewItem base_EndFlags = InitListItem("End Flags");
        private ListViewItem base_Gravity = InitListItem("Gravity");
        private ListViewItem base_SlopeLimit = InitListItem("Slope Limit");
        private ListViewItem base_CosSlope = InitListItem("Cos Slope");
        private ListViewItem base_Slide = InitListItem("Slide");
        private ListViewItem base_Rebound = InitListItem("Rebound");
        private ListViewItem base_ImposeSpeed = InitListItem("Impose Speed");
        private ListViewItem base_ProposeSpeed = InitListItem("Propose Speed");
        private ListViewItem base_PreviousSpeed = InitListItem("Previous Speed");
        private ListViewItem base_Scale = InitListItem("Scale");
        private ListViewItem base_SpeedAnim = InitListItem("Speed Anim");
        private ListViewItem base_SafeTranslation = InitListItem("Safe Translation");
        private ListViewItem base_AddTranslation = InitListItem("Add Translation");
        private ListViewItem base_FrameNum = InitListItem("Frame Number");

        // TODO: advanced and complex properties

        public DynamManager(Pointer<SuperObject> spo)
        {
            SuperObject = spo;
        }

        private static ListViewItem InitListItem(string name) => new ListViewItem(new[] { name, "" });

        public void InitListView(ListView listView, DynamicsBlockBase.DynamicsType type)
        {
            switch (type)
            {
                case DynamicsBlockBase.DynamicsType.Base:
                    listView.Items.Add(base_ObjectType);
                    listView.Items.Add(base_CurrentIdCard);
                    listView.Items.Add(base_Flags);
                    listView.Items.Add(base_EndFlags);
                    listView.Items.Add(base_Gravity);
                    listView.Items.Add(base_SlopeLimit);
                    listView.Items.Add(base_CosSlope);
                    listView.Items.Add(base_Slide);
                    listView.Items.Add(base_Rebound);
                    listView.Items.Add(base_ImposeSpeed);
                    listView.Items.Add(base_ProposeSpeed);
                    listView.Items.Add(base_PreviousSpeed);
                    listView.Items.Add(base_Scale);
                    listView.Items.Add(base_SpeedAnim);
                    listView.Items.Add(base_SafeTranslation);
                    listView.Items.Add(base_AddTranslation);
                    listView.Items.Add(base_FrameNum);
                    break;

                case DynamicsBlockBase.DynamicsType.Advanced:
                    // TODO: advanced properties
                    break;

                case DynamicsBlockBase.DynamicsType.Complex:
                    // TODO: complex properties
                    break;
            }
        }

        public void UpdateAll()
        {
            Dynam* dynam = SuperObject.StructPtr->PersoData->dynam;
            DynamicsBlockBase dynamBase = dynam->DynamicsBase->DynamicsBlockBase;

            switch (dynamBase.Type)
            {
                case DynamicsBlockBase.DynamicsType.Base:
                    UpdateBase(dynam->DynamicsBase);
                    break;

                case DynamicsBlockBase.DynamicsType.Advanced:
                    UpdateBase(dynam->DynamicsBase);
                    UpdateAdvanced(dynam->DynamicsAdvanced);
                    break;

                case DynamicsBlockBase.DynamicsType.Complex:
                    UpdateBase(dynam->DynamicsBase);
                    UpdateAdvanced(dynam->DynamicsAdvanced);
                    UpdateComplex(dynam->DynamicsComplex);
                    break;
            }

        }

        private void UpdateBase(DynamicsBase *dynamBase)
        {
            DynamicsBlockBase *baseBlock = &dynamBase->DynamicsBlockBase;

            SetListItemText(base_ObjectType, $"{baseBlock->m_lObjectType}");
            SetListItemText(base_CurrentIdCard, $"0x{baseBlock->m_pCurrentIdCard:X8}");
            SetListItemText(base_Flags, $"0x{baseBlock->ulFlags:X8}");
            SetListItemText(base_EndFlags, $"0x{baseBlock->ulEndFlags:X8}");
            SetListItemText(base_Gravity, $"{baseBlock->m_xGravity}");
            SetListItemText(base_SlopeLimit, $"{baseBlock->m_xSlopeLimit}");
            SetListItemText(base_CosSlope, $"{baseBlock->m_xCosSlope}");
            SetListItemText(base_Slide, $"{baseBlock->m_xSlide}");
            SetListItemText(base_Rebound, $"{baseBlock->m_xRebound}");

            // TODO: rest of the base items
        }
        
        private void UpdateAdvanced(DynamicsAdvanced* dynamAdvanced)
        {
            // TODO
        }

        private void UpdateComplex(DynamicsComplex* dynamComplex)
        {
            // TODO
        }

        private void SetListItemText(ListViewItem item, string value)
        {
            item.SubItems[1].Text = value;
        }
    }
}