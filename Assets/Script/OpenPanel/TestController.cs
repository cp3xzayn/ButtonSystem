using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestController : PanelManager
{
    [SerializeField] Text m_text = null;

    void Start()
    {
        m_text.GetComponent<Text>();
    }

    public override void OnClickOpenPanel(int i)
    {
        base.OnClickOpenPanel(i);
        m_text.text = "Buttonが押されました。";
    }

    public override void OnClickClosePanle(int i)
    {
        base.OnClickClosePanle(i);
    }
}
