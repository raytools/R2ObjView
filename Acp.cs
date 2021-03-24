﻿using System.Runtime.InteropServices;
using Ray2Mod.Game.Structs;
using Ray2Mod.Game.Structs.SPO;

namespace R2ObjView
{
    public static unsafe class Acp
    {
        #region HIE

        public delegate bool XHIE_tdfnEnumSpoCallback(SuperObject* p_stSpo);

        [DllImport("ACP_Ray2.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern string XHIE_fn_szGetObjectName(SuperObject* p_stSpo, XHIE_OI_TYPE ulInfoType);

        [DllImport("ACP_Ray2.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XHIE_fn_lEnumSpoChildren(SuperObject* p_stSpo, XHIE_tdfnEnumSpoCallback p_fnCallback);

        #endregion

        #region AI

        public delegate bool AI_tdfnEnumDsgVarCallback(DsgVarType ulType, void* CurrentValue, void* InitialValue);

        [DllImport("ACP_Ray2.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAI_fn_lEnumSpoDsgVars(SuperObject* p_stSpo, AI_tdfnEnumDsgVarCallback p_fnCallback);

        #endregion

        public enum XHIE_OI_TYPE
        {
            TOI_FAMILY,
            TOI_MODEL,
            TOI_INSTANCE,
            OI_TYPE_COUNT
        }
    }
}