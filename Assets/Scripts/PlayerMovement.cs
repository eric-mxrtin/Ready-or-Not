using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class <c>PlayerMovement</c> movement logic for the player.
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    /// <value>
    /// Property <c>moveSpeed</c> represents speed of player movement
    /// </value>
    public float moveSpeed = 5f;

    /// <summary>
    /// Establishes physics engine for movement, gravity, etc
    /// </summary>
    public Rigidbody2D rb;

    /// <summary>
    /// Establishes camera to follow movement of player
    /// </summary>
    public Camera cam;

    Vector2 movement; // Adding movement data to vector
    Vector2 mousePos; // Considers mouse position in vector data

    /// <summary>
    /// Updates information to movement and mousePos data for Vector2
    /// </summary>
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    /// <summary>
    /// Updates player position
    /// </summary>
    /// <param><c>angle</c> represents direction of the player's movement </param> 
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookingDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookingDir.y, lookingDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}