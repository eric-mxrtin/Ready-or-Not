using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class <c>Sibling</c> is used to remove sibling when player completes objectives
/// </summary>
public class Sibling : MonoBehaviour
{
    /// <summary>
    /// Initializes the player script for sibling to be used
    /// </summary>
    public Player playerScript;
    // Update is called once per frame
    /// <summary>
    /// Destroys sibling object when player meets objectives
    /// </summary>
    void Update()
    {
        if (playerScript.totemsCollected == 7) {
            Debug.Log("escaping");
            Destroy(this.gameObject);
        }
    }
}
