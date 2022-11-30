using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractablePanel : Interactable2
{
    [SerializeField]private encenderLuces luces;
    public override void Interact()
    {
        base.Interact();

        luces.gameObject.SetActive(true);
    }
}
