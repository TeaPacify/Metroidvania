using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigibody2D))]

// A behaviour that is attached to a playable
public class PlayerMovement : PlayableBehaviour
{
    private Rigibody2D rb2D;
    private Animator myAnimator;

    public float speed = 2.0f;
    public float horizMovement;

    private void Start()
    {
        rb2D = GetComponent<Rigibody2D>();
        myAnimator = GettComponent<myAnimator>();
    }

    private void Update ()
    {
        horizMovement = Input.GetAxis("Horizontal");
    }
    
    private void FixedUpdate()
    {
        rb2D.velocity = new Vector2(horizMovement * speed,rb2D.velocity.y);
    }
}
