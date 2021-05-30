using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// ButtonによってPanelの表示非表示を管理する基底クラス
/// ・PanelにAnimatorをアタッチする
/// </summary>
public class PanelManager : MonoBehaviour
{
    /// <summary> ButtonとPanelの情報 </summary>
    [SerializeField] PanelAnimationData[] m_data = null;

    void Awake()
    {
        SetGameObjectInfo();
    }

    /// <summary>
    /// ButtonとPanelに必要な物を初期化する
    /// </summary>
    void SetGameObjectInfo()
    {
        for (int i = 0; i < m_data.Length; i++)
        {
            int value = i;
            m_data[value].m_openButton.GetComponent<Button>()
                .onClick.AddListener(() => OnClickOpenPanel(value));
            m_data[value].m_closeButton.GetComponent<Button>()
                .onClick.AddListener(() => OnClickClosePanle(value));
            m_data[value].m_panel.GetComponent<RectTransform>();
            m_data[value].m_panelAnimator = m_data[value].m_panel.GetComponent<Animator>();
        }

    }

    /// <summary>
    /// Panelを開く時の処理
    /// </summary>
    /// <param name="i"></param>
    public virtual void OnClickOpenPanel(int i)
    {
        m_data[i].m_panelAnimator.Play("Open");
        Debug.Log("Buttonが押されました。");
    }

    /// <summary>
    /// Panelを閉じるときの処理
    /// </summary>
    /// <param name="i"></param>
    public virtual void OnClickClosePanle(int i)
    {
        m_data[i].m_panelAnimator.Play("Close");
        Debug.Log("Buttonが押されました。");
    }
}

/// <summary>
/// ButtonとPanelの情報を所持するクラス
/// </summary>
[System.Serializable]
public class PanelAnimationData
{
    public GameObject m_openButton;
    public GameObject m_closeButton;
    public GameObject m_panel;
    public Animator m_panelAnimator;
}
