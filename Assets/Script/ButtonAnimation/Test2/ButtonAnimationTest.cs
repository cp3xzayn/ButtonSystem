using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonAnimationTest : ButtonAnimationInterface
{
    public override void OnPointerDown(PointerEventData pointerEventData)
    {
        base.OnPointerDown(pointerEventData);
        Debug.Log("継承成功、ボタンが押されました。");
    }
}
