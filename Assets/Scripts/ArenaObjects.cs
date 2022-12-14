using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class <c>ArenaObjects</c> Ensures objects in arena have a collider.
/// </summary>
public class ArenaObjects : MonoBehaviour
{
    /// <summary>
    /// Makes sure hitbox is active
    /// </summary>
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Destroy(gameObject);
    }

}
