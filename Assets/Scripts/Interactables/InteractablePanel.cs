using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractablePanel : Interactable
{
    [SerializeField]private encenderLuces luces;
    public override void OnFocus()
    {
        print("Focus on " + gameObject.name);
    }

    public override void OnInteract(GameObject itemsContainer, ref List<HandItem> allPlayerObjects)
    {
        luces.gameObject.SetActive(true);
    }

    public override void OnLoseFocus()
    {
        print("Lost focus on " + gameObject.name);
    }
}
