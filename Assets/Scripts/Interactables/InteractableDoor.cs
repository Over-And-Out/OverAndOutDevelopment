using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableDoor : Interactable
{
    [Header("Custom Sounds")]
    [SerializeField] private AudioClip openDoor = default;
    [SerializeField] private AudioClip closeDoor = default;

    private bool isOpen = false;
    private bool canBeInteractedWith = true;
    private Animator animation;

    private void Start()
    {
        animation = GetComponent<Animator>();
    }

    public override void OnFocus()
    {
        print("Focus on " + gameObject.name);
    }

    public override void OnInteract(GameObject itemsContainer, ref List<HandItem> allPlayerObjects)
    {
        try
        {
            if(canBeInteractedWith)
            {
                FirtsPersonController controller = FirtsPersonController.Instance;

                isOpen = !isOpen;

                Vector3 doorTransformDirection = transform.TransformDirection(Vector3.forward);
                Vector3 playerTransformDirection = controller.transform.position - transform.position;

                float dot = Vector3.Dot(doorTransformDirection, playerTransformDirection);

                animation.SetFloat("dot", dot);
                animation.SetBool("isOpen", isOpen);
            }
        }
        catch (System.Exception)
        {
            print("Error");
        }
    }

    public void OpenDoorSound()
    {
        FirtsPersonController controller = FirtsPersonController.Instance;
        controller.PlayerAudioSource.PlayOneShot(openDoor);
    }

    public void CloseDoorSound()
    {
        FirtsPersonController controller = FirtsPersonController.Instance;
        controller.PlayerAudioSource.PlayOneShot(closeDoor);
    }

    public override void OnLoseFocus()
    {
        print("Lost focus on " + gameObject.name);
    }
}
