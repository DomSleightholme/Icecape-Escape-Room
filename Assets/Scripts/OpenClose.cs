using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenClose : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim.GetComponent<Animator>();
    }

    
    void pauseAnimationEvent()
    {
        anim.enabled = false;
    }
}
