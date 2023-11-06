using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    private PlayerMovementModel movementModel;
    private PlayerMovementView movementView;

    public void Initialize(PlayerMovementModel model, PlayerMovementView view)
    {
        movementModel = model;
        movementView = view;
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 movementDirection = new Vector2(horizontalInput, verticalInput);
        movementView.Move(movementDirection);
    }
}

