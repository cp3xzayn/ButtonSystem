using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimationOverride : ButtonAnimation
{
    void Start()
    {
        SetButtonOnClick();
    }

    public override void SetButtonOnClick()
    {
        base.SetButtonOnClick();
    }

    public override void PlayButtonAnimation(int i)
    {
        base.PlayButtonAnimation(i);
        if (i == 1)
        {
            Debug.Log("c");
        }
    }
}
