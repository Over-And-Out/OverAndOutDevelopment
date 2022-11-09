using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandLanternItem : HandItem
{
    private Light lanternLight;
    public Light luzLinterna;
    public bool activeLight; 
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

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            activeLight = !activeLight;

            if(activeLight == true)
                luzLinterna.enabled = true;

            if(activeLight == false)
                luzLinterna.enabled = false;
        }
    }
}
