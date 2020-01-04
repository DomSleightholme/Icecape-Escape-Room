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
    public bool CodeWork = false;

    void Update()
    {
        codeText.text = codeTextValue;

        if(codeTextValue.Length >= 9)
        {
            codeTextValue = "";
            Error.Play();
        }
    }

    public void AddDigit(string digit)
    {
        if (CodeWork == false)
        {
            codeTextValue += digit;
        }
        else
        {
            codeTextValue = "UNLOCKED";
        }
    }

    public void Clear()
    {
        codeTextValue = "";
    }

    public void EnterCode()
    {
        if (codeTextValue == "1234")
        {
            Debug.Log("Open");
            Enter.Play();
            codeText.text = "UNLOCKED";
            CodeWork = true;
        }
    }
}
