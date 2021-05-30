using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : PanelManager
{
    public override void OnClickOpenPanel(int i)
    {
        base.OnClickOpenPanel(i);
        Debug.Log("Panelを開きました。");
    }

    public override void OnClickClosePanle(int i)
    {
        base.OnClickClosePanle(i);
        Debug.Log("Panelを閉じました。");
    }
}
