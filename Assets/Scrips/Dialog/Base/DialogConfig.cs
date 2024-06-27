using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DialogIndex
{
    PauseDialog = 1,
    FailDialog = 2,
    SettingsDialog = 3,
    WinDialog = 4,
    QuitDialog = 5,
}
public class DialogParam
{

}

public class DialogConfig 
{
    public static DialogIndex[] dialogIndices =
    {
        DialogIndex.PauseDialog,
        DialogIndex.FailDialog,
        DialogIndex.SettingsDialog,
        DialogIndex.WinDialog,
        DialogIndex.QuitDialog,
    };
}
