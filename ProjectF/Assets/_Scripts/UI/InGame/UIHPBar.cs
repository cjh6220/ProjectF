using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHPBar : MessageListener
{
    public int HP = 127;
    public Image HPBar;
    const float saturation = 100;
    const float value = 84;

    protected override void AwakeImpl()
    {
        base.AwakeImpl();

    }
    private void Update() 
    {
        float newHue = (float)HP / 246;
        float newSaturation = saturation / 48;
        float newValue = value / 25;
        HPBar.color = Color.HSVToRGB(newHue, newSaturation, newValue);
    }
}
