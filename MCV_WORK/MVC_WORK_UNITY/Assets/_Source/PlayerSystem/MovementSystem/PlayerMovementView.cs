using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementView : MonoBehaviour
{
    public float movementSpeed;

    public Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 movementDirection)
    {
        Vector2 movement = movementDirection * movementSpeed * Time.deltaTime;
        rb.MovePosition(transform.position * movement);
    }
}

