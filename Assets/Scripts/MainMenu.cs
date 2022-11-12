using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Singleplayer()
    {
        SceneManager.LoadScene("Singleplayer");
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
