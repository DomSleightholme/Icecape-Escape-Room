using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text TimerText;
    float gameTimer = 300f;

    public Animator animator;
    public GameObject Player;

    public AudioSource DeathOfPlayer;
    

    public static bool TimesUp = false;

    public void Start()
    {
        InvokeRepeating("AudioPlay", 290, 60);
    }
    void Update()
    {
        gameTimer -= Time.deltaTime;

        int seconds = (int)(gameTimer % 60);
        int minutes = (int)(gameTimer / 60) % 60;

        string timerString = string.Format("{0:00}:{1:00}", minutes, seconds);

        TimerText.text = timerString;

        if (gameTimer < 1)
        {
            TimesUp = true;
        }

        if (TimesUp == true)
        {
            animator.SetTrigger("FadeOut");            
            StartCoroutine(Death());
        }
        
    }

    public IEnumerator Death()
    {
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene("ThankYouForPlaying");
    }

    public void AudioPlay()
    {
        DeathOfPlayer.Play();
    }
}
