using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ThankYouForPlaying : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene("MainMenu");
    }
}
