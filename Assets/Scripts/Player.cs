using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class <c>Player</c> destroys item when it comes into contact with a player.
/// </summary>
public class Player : MonoBehaviour
{
    /// <value>
    /// Property <c>totemsCollected</c> represents the number of totems collected.
    /// </value>
    public int totemsCollected = 0;
    /// <summary>
    /// Stores totem objects to be used
    /// </summary>
    public GameObject[] totems;
    /// <summary>
    /// Initializes portal object
    /// </summary>
    public ActivatePortal portal;
    /// <value>
    /// Property <c>timeStart</c> represents the time at the start of the game.
    /// </value>
    public float timeStart = 0;
    /// <summary>
    /// Represents if timer is in motion or not
    /// </summary>
    public bool timerGoing;
    /// <value>
    /// Property <c>coins</c> represents the number of coins player has collected.
    /// </value>
    public int coins = 0;

    /// <summary>
    /// Removes objects if player and object colliders come into contact
    /// </summary>
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Sibling" && totemsCollected == 7) {
            Destroy(other.gameObject, 2);
        }
        if (other.tag == "Totem") {
            Destroy(other.gameObject);
            Destroy(totems[totemsCollected].gameObject);
            totemsCollected ++;
            Debug.Log(totemsCollected);
        }
    }

    /// <summary>
    /// Sets the timer and begins running it
    /// </summary>
    void Start() 
    {
        timeStart = 0;
        timerGoing = true;
    }

    /// <summary>
    /// Updates coins and highscore
    /// </summary>
    /// <param><c>timerGoing</c> sets to false to stop timer from running </param>
    /// <param><c>coins</c> increases based on time </param>
    /// <param><c>previous_coins</c> gets the previous amount of coins </param>
    void Update() 
    {
        if (timerGoing) {
            timeStart += Time.deltaTime;
        }
        if (portal.escaped) {
            timerGoing = false;
            coins += 120 - (int)timeStart;
            int previous_coins = PlayerPrefs.GetInt("coins", 0);
            PlayerPrefs.SetInt("coins", coins + previous_coins);

            if (timeStart < PlayerPrefs.GetFloat("HighScore", 10000000000))
            {
                PlayerPrefs.SetFloat("HighScore", timeStart);
            }
            Debug.Log(PlayerPrefs.GetFloat("HighScore", -1));
            // List<float> scores;
            // scores = XMLManager.instance.LoadScores();
            // scores.Add(timeStart);
            // scores.Sort();
            // XMLManager.instance.SaveScores(scores);
        }
    }
}
