using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinDialog : BaseDialog
{
    [SerializeField] Animator animator;
    public override void OnShowDialog()
    {
        base.OnShowDialog();
        Time.timeScale = 0;
        animator.Play("Open");
    }
    public override void OnHideDialog()
    {
        base.OnHideDialog();
        animator.Play("Close");
        Time.timeScale = 1;
    }
}
