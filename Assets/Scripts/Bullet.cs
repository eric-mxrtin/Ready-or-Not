using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls the bullet projectile
/// </summary>
public class Bullet : MonoBehaviour
{
    /// <summary>
    /// Deletes bullet projectile when colliders meet
    /// </summary>
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

}
