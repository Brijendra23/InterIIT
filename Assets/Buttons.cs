using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    [SerializeField]
    private Animator settingsAnimator;
    public void Retry()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f; 
    }
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Pause()
    {
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        Time.timeScale = 1f;
    }
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
    public void Settings()
    {
        if (settingsAnimator.GetBool("enter"))
        {
            settingsAnimator.SetBool("enter", false);
            settingsAnimator.SetBool("exit", true);
        }
        else
        {
            settingsAnimator.SetBool("enter", true);
            settingsAnimator.SetBool("exit", true);
        }
    }

    [SerializeField]
    private AudioMixer musicAudioMixer;
    [SerializeField]
    private AudioMixer sfxAudioMixer;

    public void SetMusicVolume(float volume)
    {
        musicAudioMixer.SetFloat("Volume", volume);
    }
    public void SetSFXVolume(float volume)
    {
        sfxAudioMixer.SetFloat("Volume", volume);
    }

    public void SetGraphics(int graphics)
    {
        QualitySettings.SetQualityLevel(graphics);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

}