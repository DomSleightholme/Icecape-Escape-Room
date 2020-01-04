using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text TimerText;
    float gameTimer = 600f;


    void Start()
    {
        StartCoroutine(Blizzard());
    }
    void Update()
    {
        gameTimer -= Time.deltaTime;

        int seconds = (int)(gameTimer % 60);
        int minutes = (int)(gameTimer / 60) % 60;

        string timerString = string.Format("{0:00}:{1:00}", minutes, seconds);

        TimerText.text = timerString;

    }
    public IEnumerator Blizzard()
    {
        yield return new WaitForSeconds(60f);
        Debug.Log("Blizzard1");

        yield return new WaitForSeconds(180f);
        Debug.Log("Blizzard2");

        yield return new WaitForSeconds(300f);
        Debug.Log("Blizzard3");

        yield return new WaitForSeconds(420f);
        Debug.Log("Blizzard4");

        yield return new WaitForSeconds(480f);
        Debug.Log("Blizzard5");

        yield return new WaitForSeconds(570f);
        Debug.Log("Blizzard6");

        yield return new WaitForSeconds(600f);
        Debug.Log("Dead");
    }
}
