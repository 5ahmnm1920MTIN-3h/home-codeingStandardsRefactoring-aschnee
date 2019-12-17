using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const string jumping = "Jump";
    private const string ground = "Ground";
    private const string obstacle = "Obstacle";
    private const string santaDeath = "SantaDeath";

    Rigidbody2D rb;
    Animator anim;
    [SerializeField] float jumpForce;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && !gameOver && !gameOver && !gameOver)
        {
            if (grounded == true)
            {
                jump();
            }
        }
    }

    bool grounded;
    bool gameOver = false;

    void jump()
    {
        grounded = false;
        rb.velocity = Vector2.up * jumpForce;
        anim.SetTrigger(jumping);
        GameManager.instance.IncrementScore();
    }

    private bool SetGameOverTrue()
    {
        return true;
    }

    private void OnCollisionEnter2D(Collision2D collision)   {
        if(collision.gameObject.tag == ground)
        {
            grounded = true;}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == obstacle){
            GameManager.instance.GameOver();
            Destroy(collision.gameObject);
            anim.Play(santaDeath);
            gameOver = SetGameOverTrue();
        }
    }




}
