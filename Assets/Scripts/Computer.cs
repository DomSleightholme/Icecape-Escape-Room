using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour
{
    public GameObject Interact;
    public GameObject HandHover;
    public GameObject Screen;
    public static bool test = false;

    public static bool ComputerOn;

    // Start is called before the first frame update
    void Start()
    {
        Interact.SetActive(false);
        HandHover.SetActive(false);
        Screen.SetActive(false);

        ComputerOn = false;

    }

    public void OnMouseOver()
    {
        Interact.SetActive(true);
        HandHover.SetActive(true);       

        if (Input.GetKeyDown(KeyCode.E))
        {
           ComputerOn = !ComputerOn;
            if (ComputerOn)
            {
                Debug.Log("Turn Computer On");
                Screen.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                test = true;
            }
            else if (!ComputerOn)
            {
                Debug.Log("Turn Computer Off");
                Screen.SetActive(false);
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
    public void OnMouseExit()
    {
        Interact.SetActive(false);
        HandHover.SetActive(false);
    }
}
