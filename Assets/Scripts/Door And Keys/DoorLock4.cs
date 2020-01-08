using UnityEngine;
using System.Collections;

public class DoorLock4 : MonoBehaviour
{
    public GameObject Interact;
    public GameObject HandHover;
    public GameObject KeyText4;
    

    public static bool Lock4Unlock = false;

    public AudioSource Banging;
    public AudioSource UnlockSound;

    public static int Key4 = 0;

    void Start()
    {
        Interact.SetActive(false);
        HandHover.SetActive(false);
    }

    public void OnMouseOver()
    {
        Interact.SetActive(true);
        HandHover.SetActive(true);

        if (Input.GetKeyDown(KeyCode.E) && Key4 == 1)
        {
            Lock4Unlock = true;
            Key4 -= 1;
            KeyText4.SetActive(false);
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
        if (Lock4Unlock == true)
        {
            Debug.Log("test1workehehe");
        }
    }
}
