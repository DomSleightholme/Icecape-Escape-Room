using UnityEngine;
using System.Collections;
using System;

public class CameraShaker : MonoBehaviour
{
    public float power = 0.7f;
    public float duration = 1.0f;
    public Transform camera;
    public float slowDownAmount = 1.0f;
    public bool shouldShake = false;

    public AudioSource Shaking;

    Vector3 startPosition;
    float initialDuration;
    // Use this for initialization
    void Start()
    {
        camera = Camera.main.transform;
        startPosition = camera.localPosition;       
        initialDuration = duration;
        InvokeRepeating("Switch", 10, 60);
        InvokeRepeating("AudioShake", 10, 60);
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldShake)
        {
            if (duration > 0)
            {
                camera.localPosition = startPosition + UnityEngine.Random.insideUnitSphere * power;
                duration -= Time.deltaTime * slowDownAmount;
            }
            else
            {
                shouldShake = false;
                duration = initialDuration;
                camera.localPosition = startPosition;
            }
        }  
    }

    public void Switch()
    {
        shouldShake = !shouldShake;
    }

    public void AudioShake()
    {
        Shaking.Play();
    }

    





}
