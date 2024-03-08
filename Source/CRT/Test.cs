/* #------------------ License ------------------#
*  #---------- Created By FastDevil -------------#
*  #--------- You can edit this file ------------#
*  #------ This file is a example how to --------#
*  #------------ Use this library ---------------#
*  #---------------------------------------------#
*  #-------- ©Copyright FastDevil 2024 ----------#
*  #---------------------------------------------#
*/
#pragma warning disable

using FastDevil.Debug;
using FastDevil.Project;

sealed class Run{
    private static void Main(){
        App.Exec_Config();
        CRT_Warn CRTW = new CRT_Warn(-10318,"Reading invaild memory address");
        CRT_Error CRTE = new CRT_Error(271,"Failed try to delete file",5);
        CRT_Msg CRTM = new CRT_Msg("Chill,this not needs atention");
        App.WaitKeyPress();
    }
}