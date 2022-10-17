using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
    }

    public void Play(string scene_name)
    {
        Application.LoadLevel(scene_name);
    }

    public void sound_volume(float volume)
    {
        PlayerPrefs.SetFloat("volume", volume);
    }

    private void Start()
    {
        Time.timeScale = 1;
    }
}
