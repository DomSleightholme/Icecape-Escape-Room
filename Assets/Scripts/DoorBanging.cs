using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBanging : MonoBehaviour
{
    public GameObject Interact;
    public GameObject HandHover;
    public GameObject Door;

    public AudioSource BangingEffect;

    public bool isDoorOpen = false;

    public void Banging()
    {
        if (Door.transform.rotation.eulerAngles.y == 0)
        {
            isDoorOpen = true;
        }
        else if (Door.transform.rotation.eulerAngles.y == -90)
        {
            isDoorOpen = false;
            Debug.Log("testing123");
        }

    }

    public void OnMouseOver()
    {
        if (isDoorOpen == false)
        {
            Interact.SetActive(true);
            HandHover.SetActive(true);
        }
        else if(isDoorOpen == true)
        {
            Interact.SetActive(false);
            HandHover.SetActive(false);
        }
        
        if(Input.GetKeyDown(KeyCode.E) && isDoorOpen == false)
        {
            BangingEffect.Play();
        }
    }

    public void OnMouseExit()
    {
        Interact.SetActive(false);
        HandHover.SetActive(false);
    }
}
