using UnityEngine;
using System.Collections;

public class Locker : MonoBehaviour
{
    public GameObject Interact;
    public GameObject HandHover;
    public AudioSource OpenLocker;

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
            }
            else if (!LockerOpen)
            {
                Debug.Log("Locker Close");
                OpenLocker.Play();
            }
        }
    }

    public void OnMouseExit()
    {
        Interact.SetActive(false);
        HandHover.SetActive(false);
    }

}
