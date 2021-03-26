using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementPlayer : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb2d;
    public SpriteRenderer rend; 
    public float Speed = 5;
    public float jump = 5; 

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float h = Input.GetAxis("Horizontal") * Speed;

        rb2d.velocity = new Vector2(h, rb2d.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(transform.up * Speed, ForceMode2D.Impulse);
        }
        if (h > 0)
        {
            rend.flipX = false;
        }
        else if (h < 0)
        {
            rend.flipX = true;
        }
        float characterVelocity = Mathf.Abs(h);
        animator.SetFloat("speed", characterVelocity);
    }
   
}
