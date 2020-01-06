using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodePanel : MonoBehaviour
{
    public Text codeText;
    public string codeTextValue = "";

    public AudioSource Error;
    public AudioSource Enter;
    public AudioSource KeyEnter;

    public bool CodeWork = false;

    public GameObject Door;

    public Animator LockerRoom;

    void Update()
    {
        //This states that the UI text is equal to the text value entered.
        codeText.text = codeTextValue;

        if(codeTextValue.Length >= 9)
        {
            codeTextValue = "";
            Error.Play();
        }

        //The Code below will enter the spefic key into the Computer terminal
        if (CodeWork == false)
        {
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                codeTextValue += "0";
                KeyEnter.Play();
            }
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                codeTextValue += "1";
                KeyEnter.Play();
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                codeTextValue += "2";
                KeyEnter.Play();
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                codeTextValue += "3";
                KeyEnter.Play();
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                codeTextValue += "4";
                KeyEnter.Play();
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                codeTextValue += "5";
                KeyEnter.Play();
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                codeTextValue += "6";
                KeyEnter.Play();
            }
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                codeTextValue += "7";
                KeyEnter.Play();
            }
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                codeTextValue += "8";
                KeyEnter.Play();
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                codeTextValue += "9";
                KeyEnter.Play();
            }
        }

        //This code will run if the user gets the correct code.
        if (codeTextValue == "57206413")
        {
            Debug.Log("Open");
            Enter.Play();
            codeText.text = "UNLOCKED";
            CodeWork = true;
            Debug.Log("Open Door");
            LockerRoom.SetTrigger("CodeWork");
        }

        void pauseAnimationEvent()
        {
            LockerRoom.enabled = false;
        }
    }
}
