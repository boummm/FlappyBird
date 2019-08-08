using UnityEngine;
using System.Collections;
using System.Collections.Generic;  

public class Bird : MonoBehaviour 
{
    public float upForce = 200;                   
    private bool isDead = false;            

    private Animator anim;                    
    private Rigidbody2D rb2d;                

    void Start()
    {
        anim = GetComponent<Animator> ();
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isDead == false) 
        {
            if (Input.GetMouseButtonDown(0)) 
            {
                rb2d.velocity = Vector2.zero;
                //    new Vector2(rb2d.velocity.x, 0);
                rb2d.AddForce(new Vector2(0, upForce));
                anim.SetTrigger("Flap");
            }
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        // rb2d.velocity = Vector2.zero;
        isDead = true;
        anim.SetTrigger ("Die");    
        // GameControl.instance.BirdDied ();
    }
}