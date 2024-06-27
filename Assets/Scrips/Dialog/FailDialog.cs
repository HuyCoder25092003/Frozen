using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailDialog : BaseDialog
{
    // Start is called before the first frame update
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
}
