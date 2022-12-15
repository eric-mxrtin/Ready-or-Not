using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Class <c>ActivatePortal</c> manages portal behaviour.
/// </summary>
public class ActivatePortal : MonoBehaviour
{
    /// <summary>
    /// Initializes the correct portal sprite
    /// </summary>
    public Sprite PortalOn;
    /// <value>
    /// Property <c>activeTime</c> represents time the portal is active
    /// </value>
    public int activateTime;
    /// <summary>
    /// Represents if the portal is on or not
    /// </summary>
    public bool isPortalOn;
    /// <summary>
    /// Represents if the player has escaped, gone through the portal
    /// </summary>
    public bool escaped;
    /// <summary>
    /// Initializes the player script for player controls
    /// </summary>
    public Player playerScript;
    /// <summary>
    /// Initializes the timer for calculating score
    /// </summary>
    public ScoringTimer scoringTimer;
    
    //public bool IsTouching(Collider2D collider, ContactFilter2D contactFilter);
    // Start is called before the first frame update
    /// <summary>
    /// Turns on the portal
    /// </summary>
    void Start()
    {
        // Invoke("turnOnPortal", 1);
    }

    // Update is called once per frame
    /// <summary>
    /// Portal turns on if player has collected all the totems
    /// </summary>
    void Update()
    {
        if (playerScript.totemsCollected == 7) {
            Debug.Log("escaping1");
            turnOnPortal();
        }
    }
    /// <summary>
    /// Loads scene depending on totems collected and if time is remaining
    /// </summary>
    void OnTriggerEnter2D(Collider2D other) 
    {
        escaped = true;
        if (playerScript.totemsCollected == 7 && scoringTimer.timerIsActive) {
            SceneManager.LoadScene("WinningScreen");
        }
        else {
            SceneManager.LoadScene("LosingScreen");
        }
    }

    /// <summary>
    /// Turns on the portal
    /// </summary>
    void turnOnPortal()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = PortalOn;
        isPortalOn = true;
        this.gameObject.GetComponent<Collider2D>().isTrigger = true;
    }
    
}
