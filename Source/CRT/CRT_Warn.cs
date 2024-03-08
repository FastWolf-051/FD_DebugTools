﻿/* #------------------ License ------------------#
*  #---------- Created By FastDevil -------------#
*  #--------- DO NOT EDIT this file -------------#
*  #------- This file is a library part ---------#
*  #---------------------------------------------#
*  #-------- ©Copyright FastDevil 2024 ----------#
*  #---------------------------------------------#
*/

#pragma warning disable

using FastDevil.Debug.CRT_Tasks;

namespace FastDevil.Debug;

sealed class CRT_Warn : CRT_WarnT {
    private readonly long _warnCode;
    private readonly string? _warnReason;
    private readonly byte _errorColor = 6;
    private readonly string _lbr = "\n";
    public void CE_Warn(){
        Console.ForegroundColor = (ConsoleColor)_errorColor;
        CE_Warn_Code(_warnCode);
        CE_Warn_Info(_warnReason);
        CE_Lbr();
        Console.ForegroundColor = ConsoleColor.White;
    }
    private void CE_Lbr(){
        Console.Write(_lbr);
    }
    private void CE_Warn_Code(long _code){
        Console.Write($"Warning code: {_code}, ");
    }
    private void CE_Warn_Info(string? _info) {
        Console.Write($"Reason: {_info}");
    }
    public CRT_Warn(long _warnCode,string? _warnReason){
        this._warnCode = _warnCode;
        this._warnReason = _warnReason;
        CE_Warn();
    }
}