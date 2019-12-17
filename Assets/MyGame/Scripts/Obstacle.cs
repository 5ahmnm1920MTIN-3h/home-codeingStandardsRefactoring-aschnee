using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private const float obsDistance = 15f;
Rigidbody2D rb;
[SerializeField] private float MoveSpeed;

private void Awake()
{
    rb = GetComponent<Rigidbody2D>();
}

// Update is called once per frame
void Update()
{
    //if obstacle's position x is < -15f it will be destroyed
    if(transform.position.x < -obsDistance)
    {
        Destroy(gameObject);
}
        //if obstacle's position x is < -15f it will be destroyed
        if (transform.position.x > obsDistance)
        {
            Destroy(gameObject);
        }
    }

private void FixedUpdate()
{
    rb.velocity = Vector2.left * MoveSpeed;
}
}
