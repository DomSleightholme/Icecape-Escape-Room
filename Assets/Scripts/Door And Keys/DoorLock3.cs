using UnityEngine;
using System.Collections;

public class DoorLock3 : MonoBehaviour
{
    public GameObject Interact;
    public GameObject HandHover;
    public GameObject KeyText3;

    public static bool Lock3Unlock = false;

    public AudioSource Banging;
    public AudioSource UnlockSound;

    public static int Key3 = 0;

    void Start()
    {
        Interact.SetActive(false);
        HandHover.SetActive(false);
    }

    public void OnMouseOver()
    {
        Interact.SetActive(true);
        HandHover.SetActive(true);

        if (Input.GetKeyDown(KeyCode.E) && Key3 == 1)
        {
            Lock3Unlock = true;
            Key3 -= 1;
            KeyText3.SetActive(false);
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
        if (Lock3Unlock == true)
        {
            Debug.Log("test1workehehe");
        }
    }
}