using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls the objects that can be collected in game
/// </summary>
public class Collectibles : MonoBehaviour
{
    /// <summary>
    /// Destroys collectible when colliding with a player
    /// </summary>
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player") {
            Debug.Log("totem");
            Destroy(this.gameObject);
        }
    }
}
