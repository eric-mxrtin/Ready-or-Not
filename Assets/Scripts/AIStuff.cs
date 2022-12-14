using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

/// <summary>
/// Class <c>AIStuff</c> movement logic for the seeker.
/// </summary>

public class AIStuff : MonoBehaviour
{
    /// <summary>
    /// This constructor initializes the movement data of the bot.
    /// </summary>
    public Animator anim;

    /// <value>
    /// Property <c>moveSpeed</c> represents the movement speed of the bot.
    /// </value>
    public float moveSpeed;

    /// <summary>
    /// This constructor initializes the body physics of the bot.
    /// </summary>
    private Rigidbody2D rb;

    /// <value>
    /// Property <c>x</c> represents the AI's x-coordinate.
    /// </value>
    private float x;

    /// <value>
    /// Property <c>y</c> represents the point's y-coordinate.
    /// </value>
    private float y;

    /// <summary>
    /// This constructor initializes the new location of the AI bot.
    /// </summary>
    private Vector2 input;

    /// <summary>
    /// This constructor represents if the AI is moving or not.
    /// </summary>
    private bool moving;

    /// <summary>
    /// This constructor initializes the pathfinding data of the bot.
    /// </summary>
    public AIPath aiPath;

    /// <summary>
    /// This method gets the rigid body component
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
    /// Gives values to the vector variable
    /// </summary>
    private void GetInput()
    {
        x = aiPath.desiredVelocity.x;
        y = aiPath.desiredVelocity.y;

        input = new Vector2(x, y); //Creating a new vector
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