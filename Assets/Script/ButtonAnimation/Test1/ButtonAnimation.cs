using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAnimation : MonoBehaviour
{
    /// <summary> Button </summary>
    [SerializeField] GameObject[] m_buttons = null;
    /// <summary> 選択されたButton </summary>
    GameObject m_selectedButton = null;

    /// <summary>
    /// Buttonに関数を登録する
    /// </summary>
    public virtual void SetButtonOnClick()
    {
        Debug.Log("b");
        for (int i = 0; i < m_buttons.Length; i++)
        {
            int value = i; // キャプチャーのため、変数に格納する
            m_buttons[i].GetComponent<Button>().onClick.AddListener(() => PlayButtonAnimation(value));
        }
    }

    /// <summary>
    /// ButtonをAnimationさせる（機能を追加する場合、overrideさせて追加する）
    /// </summary>
    /// <param name="i"></param>
    public virtual void PlayButtonAnimation(int i)
    {
        m_selectedButton = m_buttons[i];
        RectTransform rt = m_selectedButton.GetComponent<RectTransform>();
        StartCoroutine(StartButtonAnimation(rt, 0.9f, 1f));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="rt"></param>
    /// <param name="minSize"></param>
    /// <param name="maxSize"></param>
    /// <returns></returns>
    IEnumerator StartButtonAnimation(RectTransform rt, float minSize, float maxSize)
    {
        rt.localScale = new Vector2(minSize, minSize);
        yield return new WaitForSeconds(0.1f);
        rt.localScale = new Vector2(maxSize, maxSize);
        yield break;
    }
}
