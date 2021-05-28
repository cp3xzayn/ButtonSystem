using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonDrag : MonoBehaviour
    //, IBeginDragHandler, IDragHandler
{
    [SerializeField] GameObject[] m_buttons = null;
    GameObject m_selectButton = null;



    void Start()
    {
        for (int i = 0; i < m_buttons.Length; i++)
        {
            int value = i; //キャプチャーのため、変数に格納する
            m_buttons[i].GetComponent<Button>().onClick.AddListener(() => OnClickButton(value));
        }
    }


    void Update()
    {
    }

    /// <summary>
    /// Buttonが押されたときの処理
    /// </summary>
    /// <param name="value"></param>
    public void OnClickButton(int value)
    {
        Debug.Log("Button選択");
        m_selectButton = m_buttons[value];
    }

    void ButtonSizeChange()
    {
        Touch touch;
        if (Input.touchCount == 2)
        {
            if (Input.touches[0].phase == TouchPhase.Moved || Input.touches[1].phase == TouchPhase.Moved)
            {
                
            }
        }
    }

    ///// <summary>
    ///// ドラッグ開始時に呼び出される
    ///// </summary>
    ///// <param name="eventData"></param>
    //public void OnBeginDrag(PointerEventData eventData)
    //{
    //    m_selectButton.transform.position = transform.position;
    //}

    ///// <summary>
    ///// ドラッグ中に呼び出される
    ///// </summary>
    ///// <param name="eventData"></param>
    //public void OnDrag(PointerEventData eventData)
    //{
    //    m_selectButton.transform.position = eventData.position;
    //}

}

