using UnityEngine;
using System.Collections;

public class DoorLock1 : MonoBehaviour
{
    public GameObject Interact;
    public GameObject HandHover;
    public GameObject KeyText1;

    public static bool Lock1Unlock = false;

    public AudioSource Banging;
    public AudioSource UnlockSound;

    public static int Key1 = 0;

    void Start()
    {
        Interact.SetActive(false);
        HandHover.SetActive(false);
    }

    public void OnMouseOver()
    {
        Interact.SetActive(true);
        HandHover.SetActive(true);

        if (Input.GetKeyDown(KeyCode.E) && Key1 == 1)
        {
            Lock1Unlock = true;
            Key1 -= 1;
            KeyText1.SetActive(false);
            Interact.SetActive(false);
            HandHover.SetActive(false);
            UnlockSound.Play();
            transform.position = new Vector3(0, 0, 0);
        }
    }

    public void OnMouseExit()
    {
        Interact.SetActive(false);
        HandHover.SetActive(false);
    }

    public void DoorUnlock()
    {
        if(Lock1Unlock == true)
        {
            Debug.Log("test1workehehe");
        }
    }
}

