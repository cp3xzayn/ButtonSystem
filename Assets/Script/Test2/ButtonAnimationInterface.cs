using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonAnimationInterface : MonoBehaviour ,
    IPointerDownHandler, IPointerUpHandler
{
    RectTransform rt;

    void Start()
    {
        rt = GetComponent<RectTransform>();
    }

    public virtual void OnPointerDown(PointerEventData pointerEventData)
    {
        Debug.Log("a");
        rt.localScale = new Vector2(0.9f, 0.9f);
    }

    public virtual void OnPointerUp(PointerEventData eventData) 
    {
        Debug.Log("b");
        rt.localScale = new Vector2(1f, 1f);
    }
}
