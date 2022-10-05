using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

    public static MusicManager instance; //Singleton Instance
    AudioSource music;
    float fairyTimerMax = 3.0f;
    float fairyTimer = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        if (!instance) //Making sure this is the only instance
        {
            instance = this;
        }
        music = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (fairyTimer > 0.0f)
        {
            music.pitch = 2.0f;
            fairyTimer -= Time.deltaTime;
        }
        else
        {
            music.pitch = 1.0f;
            fairyTimer = 0.0f;
        }
    }

    public void ActivateFairy()
    {
        fairyTimer = fairyTimerMax;
    }
}
