using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    public Animator animator;
    public GameObject Player;

    public IEnumerator MainMenu()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("MainMenu");
    }

    public IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("SplashScreen");
    }

    public IEnumerator ThankYouScene()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("ThankYouForPlaying");
    }

    public void FadeToMenu()
    {
        animator.SetTrigger("FadeOut");
        StartCoroutine(MainMenu());
    }
    public void FadeToThankYou()
    {
        animator.SetTrigger("FadeOut");
        StartCoroutine(ThankYouScene());
    }
    public void FadeToLevel()
    {
        animator.SetTrigger("FadeOut");
        StartCoroutine(LoadLevel());
    }

    public void Escaped()
    {
        if (DoorLock1.Lock1Unlock == true && DoorLock2.Lock2Unlock == true && DoorLock3.Lock3Unlock == true && DoorLock4.Lock4Unlock == true)
        {
            FadeToThankYou();
            Destroy(Player);
        }
    }

    public static void Death()
    {
        Debug.Log("test1");
    }
}
