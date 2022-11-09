using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandLanternItem : HandItem
{
    private Light lanternLight;
    public virtual void Awake()
    {
        lanternLight = GetComponentInChildren<Light>();
    }

    public override void UseItem()
    {
        if (lanternLight)
        {
            lanternLight.enabled = !lanternLight.enabled;
        }
    }
}
