using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class KeyLocks : MonoBehaviour
{
    public void Update()
    {
        if (DoorLock1.Lock1Unlock == true && DoorLock2.Lock2Unlock == true && DoorLock3.Lock3Unlock == true && DoorLock4.Lock4Unlock == true)
        {
            SceneManager.LoadScene("ThankYouForPlaying");
        }
    }

}
