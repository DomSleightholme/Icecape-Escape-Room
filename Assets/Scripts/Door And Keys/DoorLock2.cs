using UnityEngine;
using System.Collections;

public class DoorLock2 : MonoBehaviour
{
    public GameObject Interact;
    public GameObject HandHover;
    public GameObject KeyText2;

    public static bool Lock2Unlock = false;

    public AudioSource Banging;
    public AudioSource UnlockSound;

    public static int Key2 = 0;

    void Start()
    {
        Interact.SetActive(false);
        HandHover.SetActive(false);
    }

    public void OnMouseOver()
    {
        Interact.SetActive(true);
        HandHover.SetActive(true);

        if (Input.GetKeyDown(KeyCode.E) && Key2 == 1)
        {
            Lock2Unlock = true;
            Key2 -= 1;
            KeyText2.SetActive(false);
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
        if (Lock2Unlock == true)
        {
            Debug.Log("test1workehehe");
        }
    }
}

