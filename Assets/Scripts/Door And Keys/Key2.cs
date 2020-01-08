using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Key2 : MonoBehaviour
{
    public GameObject KeyText;

    public GameObject Interact;
    public GameObject HandHover;

    void Start()
    {
        Interact.SetActive(false);
        HandHover.SetActive(false);
        KeyText.SetActive(false);
    }

    public void OnMouseOver()
    {
        Interact.SetActive(true);
        HandHover.SetActive(true);


        if (Input.GetKeyDown(KeyCode.E))
        {
            DoorLock2.Key2 += 1;
            KeyText.SetActive(true);
            Destroy(gameObject);
            Interact.SetActive(false);
            HandHover.SetActive(false);
        }
    }

    public void OnMouseExit()
    {
        Interact.SetActive(false);
        HandHover.SetActive(false);
    }
}