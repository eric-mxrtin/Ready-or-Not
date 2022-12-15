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
    public float timeStart;
    public bool timerGoing;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Totem") {
            Destroy(other.gameObject);
            Destroy(totems[totemsCollected].gameObject);
            totemsCollected ++;
            Debug.Log(totemsCollected);
        }
    }

    void Start() 
    {
        timerGoing = true;
    }
    void Update() 
    {
        if (timerGoing) {
            timeStart += Time.deltaTime;
        }
        if (portal.isPortalOn) {
            timerGoing = false;
            List<float> scores;
            scores = XMLManager.instance.LoadScores();
            scores.Add(timeStart);
            scores.Sort();
            XMLManager.instance.SaveScores(scores);
        }
    }
}
