﻿/* #------------------ License ------------------#
*  #---------- Created By FastDevil -------------#
*  #--------- DO NOT EDIT this file -------------#
*  #------- This file is a library part ---------#
*  #---------------------------------------------#
*  #-------- ©Copyright FastDevil 2024 ----------#
*  #---------------------------------------------#
*/

#pragma warning disable

namespace FastDevil.Debug.CRT_Tasks;

internal interface CRT_ErrorT{
    public void CE_Error();
}

internal interface CRT_WarnT{
    public void CE_Warn();
}

internal interface CRT_MsgT{
    public void CE_Msg();
}
internal interface CRT_DoneT {  
    public void CE_Done();
}