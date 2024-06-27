using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitDialog : BaseDialog
{
    [SerializeField] AudioSource yesSource, noSource, closeSource;
    [SerializeField] ParticleSystem yesParticle, noParticle;
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
    public void QuitGame()
    {
        yesParticle.Play();
        yesSource.Play(); 
        Application.Quit();
    }
    public void NotQuitGame()
    {
        noParticle.Play();
        noSource.Play();
    }
    public void OnCloseDialog()
    {
        closeSource.Play();
        DialogManager.instance.HideDialog(DialogIndex.QuitDialog);
        DialogManager.instance.ShowDialog(DialogIndex.PauseDialog);
    }
}
