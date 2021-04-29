using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public string firstSceneName;

    public void Play()
    {
        SceneManager.LoadScene(firstSceneName);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
