using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Class <c>ScoringTimer</c> is a timer used to calculate player score.
/// </summary>
public class ScoringTimer : MonoBehaviour
{
    /// <value>
    /// Property <c>currentTime</c> represents the present.
    /// </value>
    public float currentTime = 0f;
    /// <value>
    /// Property <c>startingTime</c> represents the time before the game begins.
    /// </value>
    public float startingTime = 10f;
    /// <summary>
    /// Represents if the timer is currently running
    /// </summary>
    public bool timerIsActive = true;
    /// <summary>
    /// Initializes the countown text displayed on screen
    /// </summary>
    public GameObject countdownText;


    /// <summary>
    /// Resets the current time
    /// </summary>
    void Start()
    {
       currentTime = startingTime;
    }

    /// <summary>
    /// Updates timer when timer is in use, loads main menu when timer reaches 0
    /// </summary>
    /// <param><c>minutes</c> is the current time stored in minutes </param>
    /// <param><c>seconds</c> is the current time stored in seconds </param>
    void Update()
    {
        if (timerIsActive)
        {
        currentTime -= 1 * Time.deltaTime;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);
        countdownText.GetComponent<TMPro.TextMeshProUGUI>().text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }

        if(currentTime <= 0)
        {
            currentTime = 0;
            timerIsActive = false;
            SceneManager.LoadScene("Main Menu");

        }
    }   

}
