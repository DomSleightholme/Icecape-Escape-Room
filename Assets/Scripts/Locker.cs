using UnityEngine;
using System.Collections;

public class Locker : MonoBehaviour
{
    public GameObject Interact;
    public GameObject HandHover;
    public AudioSource OpenLocker;

    public Animator anim;

    public static bool LockerOpen;
    void Start()
    {
        Interact.SetActive(false);
        HandHover.SetActive(false);
    }

    public void OnMouseOver()
    {
        Interact.SetActive(true);
        HandHover.SetActive(true);

        if (Input.GetKeyDown(KeyCode.E))
        {
            LockerOpen = !LockerOpen;
            if (LockerOpen)
            {
                Debug.Log("Locker Open");
                OpenLocker.Play();
                anim.SetTrigger("OpenDoor");
            }
            else if (!LockerOpen)
            {
                Debug.Log("Locker Close");
                anim.enabled = true;
            }
        }
    }

    public void OnMouseExit()
    {
        Interact.SetActive(false);
        HandHover.SetActive(false);
    }

    void pauseAnimationEvent()
    {
        anim.enabled = false;
    }
}
