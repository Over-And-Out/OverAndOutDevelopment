using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public static readonly int INTERACTABLE_LAYER = 6;

    public virtual void Awake()
    {
        gameObject.layer = INTERACTABLE_LAYER;
    }

    public abstract void OnInteract();
    public abstract void OnFocus();
    public abstract void OnLoseFocus();
}
