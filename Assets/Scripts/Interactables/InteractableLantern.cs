using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableLantern : Interactable
{
    public override void OnFocus()
    {
        print("Focus on " + gameObject.name);
    }

    public override void OnInteract(GameObject itemsContainer, ref List<HandItem> allPlayerObjects)
    {
        if (!CheckLanternInPlayer(allPlayerObjects))
        {
            GameObject lantern = Instantiate(prefab) as GameObject;
            HandLanternItem itemToAdd = lantern.GetComponent<HandLanternItem>();

            lantern.transform.parent = itemsContainer.transform;
            lantern.gameObject.transform.localPosition = itemPosition;
            lantern.transform.localRotation = itemRotation;
            lantern.SetActive(false);

            Destroy(this.gameObject);
            allPlayerObjects.Add(itemToAdd);
        }
    }

    private bool CheckLanternInPlayer(List<HandItem> allPlayerObjects)
    {
        foreach (var item in allPlayerObjects)
        {
            if (item is HandLanternItem)
                return true;
        }

        return false;
    }

    public override void OnLoseFocus()
    {
        print("Lose focus on " + gameObject.name);
    }
}
