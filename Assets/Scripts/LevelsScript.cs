using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsScript : MonoBehaviour
{
    public void Forest()
    {
        SceneManager.LoadScene("SinglePlayerF");
    }

    public void AbandonedBuilding()
    {
        SceneManager.LoadScene("SingleplayerA");
    }

    public void Cave()
    {
        SceneManager.LoadScene("SingleplayerC");
    }
}

