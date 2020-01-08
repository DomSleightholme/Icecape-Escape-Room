using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
 IEnumerator Start()
    {
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene("Escape Room");
    }    
}
