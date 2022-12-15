using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class <c>playermovement2</c> movement logic for the player.
/// </summary>
public class playermovement2 : MonoBehaviour
{

    /// <summary>
    /// This constructor initializes the movement data of the bot.
    /// </summary>
    public Animator anim;

    /// <value>
    /// Parameter <c>moveSpeed</c> represents movement speed of the player
    /// </value>
    public float moveSpeed;

    /// <summary>
    /// Establishes physics engine for movement, gravity, etc
    /// </summary>
    private Rigidbody2D rb;

    /// <value>
    /// Parameter <c>x</c> represents the position of the player on the x axis
    /// </value>
    private float x;

    /// <value>
    /// Parameter <c>y</c> represents the position of the player on the y axis
    /// </value>
    private float y;

    /// <summary>
    /// This constructor initializes the new location of the player.
    /// </summary>
    private Vector2 input;

    /// <summary>
    /// This constructor represents if the AI is moving or not.
    /// </summary>
    private bool moving;

    /// <summary>
    /// This method gets the physics engine component
    /// </summary>
    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Updates GetInput() and Animate() data from future values given
    /// </summary>
    private void Update()
    {
        GetInput();
        Animate();
    }

    /// <summary>
    /// Movement for the physics engine on the player
    /// </summary>
    private void FixedUpdate()
    {
        rb.velocity = input * moveSpeed;
    }

    /// <summary>
    /// Gives values to the vector variable
    /// </summary>
    private void GetInput()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        input = new Vector2(x, y);
        input.Normalize();
    }

    /// <summary>
    /// Determines if player is moving, changes anim variable values if player is in motion
    /// </summary>
    /// <param><c>moving</c> is being checked to determine if the player is in motion </param>
    private void Animate()
    {
        if(input.magnitude > 0.1f || input.magnitude < -0.1f)
        {
            moving = true;
        }
        else
        {
            moving = false;
        }

        if(moving)
        {
            anim.SetFloat("X", x);
            anim.SetFloat("Y", y);
        }

        anim.SetBool("Moving", moving);
    }
}