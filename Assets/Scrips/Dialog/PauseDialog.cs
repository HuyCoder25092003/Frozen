using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseDialog : BaseDialog
{
    [SerializeField] AudioSource quitSource;
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
    public void OnClose()
    {
        DialogManager.instance.HideDialog(DialogIndex.PauseDialog);
    }
    public void OnQuit()
    {
        quitSource.Play();
        DialogManager.instance.HideDialog(dialogIndex);
        LoadSceneManager.instance.LoadSceneByIndex(1, () =>
        {
         //   ViewManager.instance.SwitchView(ViewIndex.HomeView);

        });
    }
    public void OnRestart()
    {
        DialogManager.instance.HideDialog(dialogIndex);
        //LoadSceneManager.instance.LoadSceneByName(GameManager.instance.cur_cf_mission.SceneName, () =>
        //{
        //    ViewManager.instance.SwitchView(ViewIndex.IngameView);
        //});
    }
}
