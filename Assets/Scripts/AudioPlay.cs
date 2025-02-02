using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    public AudioClip audioClip;
    private AudioSource audioSource;
    public bool playAudio = false;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = audioClip;
    }

    void Update()
    {
        if (playAudio && !audioSource.isPlaying)
        {
            audioSource.Play();
            playAudio = false;
            StartCoroutine(ResetPlayAudio());
        }
    }

    private IEnumerator ResetPlayAudio()
    {
        yield return new WaitForSeconds(audioClip.length);
        playAudio = false;
    }

    // Method to be called by button press
    public void TriggerAudioPlay()
    {
        playAudio = true;
    }
}
