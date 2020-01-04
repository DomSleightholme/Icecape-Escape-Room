using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Radio : MonoBehaviour
{
    public GameObject Interact;
    public GameObject HandHover;
    public AudioSource Music;
    public AudioSource Static;

    public bool OnRadio;

    // Start is called before the first frame update
    void Start()
    {
        Interact.SetActive(false);
        HandHover.SetActive(false);

        OnRadio = false;
    }

    public void OnMouseOver()
    {
       Interact.SetActive(true);
       HandHover.SetActive(true);

      if (Input.GetKeyDown(KeyCode.E))
        {
            OnRadio = !OnRadio;
            if (OnRadio)
            {
                Debug.Log("Turn On");
                Music.Play();
                Static.Stop();
            }
            else if (!OnRadio)
            {
                Debug.Log("Turn Off");
                Static.Play();
                Music.Stop();
            }
        }
    }

    public void OnMouseExit()
    {
        Interact.SetActive(false);
        HandHover.SetActive(false);
    }

    void Update()
    {

    }
}
