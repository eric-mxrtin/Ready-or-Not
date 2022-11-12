using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Levels()
    {
        SceneManager.LoadScene("Levels");
    }

    public void Multiplayer()
    {
        SceneManager.LoadScene("Multiplayer");
    }

    public void Scores()
    {
        SceneManager.LoadScene("Scores");
    }
}
