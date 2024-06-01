using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public void SwitchScene(int i)
    {
        SceneManager.LoadScene(i);       
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
