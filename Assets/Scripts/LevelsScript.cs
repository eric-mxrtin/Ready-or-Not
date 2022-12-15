using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Class <c>LevelScript</c> Loads correct maps for player.
/// </summary>
public class LevelsScript : MonoBehaviour
{

    /// <summary>
    /// Opens forrest player map as scene
    /// </summary>
    public void Forest()
    {
        SceneManager.LoadScene("SinglePlayerF");
    }
    /// <summary>
    /// Opens office player map as scene
    /// </summary>
    public void AbandonedBuilding()
    {
        SceneManager.LoadScene("SingleplayerO");
    }
    /// <summary>
    /// Opens cave player map as scene
    /// </summary>
    public void Cave()
    {
        SceneManager.LoadScene("SingleplayerC");
    }
}