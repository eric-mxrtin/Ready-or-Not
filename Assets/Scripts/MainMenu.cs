using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Class <c>MainMenu</c> Loads scenes based on player choice.
/// </summary>
public class MainMenu : MonoBehaviour
{
    /// <summary>
    /// Opens levels user interface scene
    /// </summary>
    public void Levels()
    {
        SceneManager.LoadScene("Levels");
    }
    /// <summary>
    /// Opens multiplayer user interface scene
    /// </summary>
    public void Multiplayer()
    {
        SceneManager.LoadScene("Multiplayer");
    }
    /// <summary>
    /// Opens scores user interface scene
    /// </summary>
    public void Scores()
    {
        SceneManager.LoadScene("Scores");
    }
    /// <summary>
    /// Opens shop user interface scene
    /// </summary>
    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }
    /// <summary>
    /// Resets score and coin data
    /// </summary>
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
    }
}