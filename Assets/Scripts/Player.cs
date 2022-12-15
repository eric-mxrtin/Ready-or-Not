using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class <c>Player</c> destroys item when it comes into contact with a player.
/// </summary>

public class Player : MonoBehaviour
{
    public int totemsCollected = 0;
    public GameObject[] totems;
    public ActivatePortal portal;
    public float timeStart = 0;
    public bool timerGoing;
    public int coins = 0;

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

    void Start() 
    {
        timeStart = 0;
        timerGoing = true;
    }
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
