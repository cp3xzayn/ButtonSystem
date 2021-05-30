using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Animator))]
public class PanelManager : MonoBehaviour
{
    /// <summary> Panelを開くボタン </summary>
    [SerializeField] Button[] m_openButton = null;
    /// <summary> Panleを閉じるボタン </summary>
    [SerializeField] Button[] m_closeButton = null;
    /// <summary> 開閉するPanel </summary>
    [SerializeField] RectTransform[] m_panel = null;

    Animator m_animator;

    void Start()
    {
        SetButtonOnClick();
    }

    void SetButtonOnClick()
    {
        for (int i = 0; i < m_openButton.Length; i++)
        {
            int value = i;
            m_openButton[i].onClick.AddListener(() => OnClickOpenPanel(value));
        }

        for (int i = 0; i < m_closeButton.Length; i++)
        {
            int value = i;
            m_closeButton[i].onClick.AddListener(() => OnClickClosePanle(value));
        }
    }

    public virtual void OnClickOpenPanel(int i)
    {
        m_panel[i].localScale = Vector2.one;
        Debug.Log("Buttonが押されました。");
    }

    public virtual void OnClickClosePanle(int i)
    {
        m_panel[i].localScale = Vector2.zero;
        Debug.Log("Buttonが押されました。");
    }
}
