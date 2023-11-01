using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(0);
    }
    public void Menu()
    {
        SceneManager.LoadScene(1);
    }
    public void Dont()
    {
        SceneManager.LoadScene(2);
    }
    public void really()
    {
        SceneManager.LoadScene(3);
    }
}
