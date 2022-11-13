using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class AIStuff : MonoBehaviour
{
    public Animator anim;

    public float moveSpeed;

    private Rigidbody2D rb;

    private float x;
    private float y;

    private Vector2 input;
    private bool moving;

    public AIPath aiPath;

    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        GetInput();
        Animate();
    }

    private void GetInput()
    {
        x = aiPath.desiredVelocity.x;
        y = aiPath.desiredVelocity.y;

        input = new Vector2(x, y);
        input.Normalize();
    }

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
