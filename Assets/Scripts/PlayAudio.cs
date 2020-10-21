using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource ourAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayTheAudio()
    {

        if(ourAudioSource.isPlaying == true)
        {
            //already playing
            //do nothing
        } else
        {
            //nothing is playing
            ourAudioSource.Play();

        }


    }
}
