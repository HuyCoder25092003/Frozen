using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsDialog : BaseDialog
{
    [SerializeField] AudioSource audio_source_close;
    public override void OnShowDialog()
    {
        base.OnShowDialog();
        Time.timeScale = 0;
    }
    public override void OnHideDialog()
    {
        base.OnHideDialog();
        Time.timeScale = 1;
    }
    public void OnHomeView()
    {
        audio_source_close.Play();
        DialogManager.instance.HideDialog(DialogIndex.SettingsDialog);
    }
}
