using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    private AudioSource audioSource;

    private AudioClip rotateSound;
    private AudioClip winSound;

    public void PlayRotateSound()
    {
        if (rotateSound == null)
        {
            rotateSound = Resources.Load<AudioClip>("rotation_sound");
        }

        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(rotateSound);

        }
        else
        {
            audioSource.PlayOneShot(rotateSound);
        }
    }

    public void PlayWinSound()
    {
        if (winSound == null)
        {
            winSound = Resources.Load<AudioClip>("level_win");
        }
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(winSound);

        }
        else
        {
            audioSource.PlayOneShot(winSound);
        }
    }

    public void PlayButtonClick()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.Play();

        }
        else
        {
            audioSource.Play();
        }
    }
  
}
