using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementModel : MonoBehaviour
{
    private PlayerMovementView movementView;

    public void Initialize(PlayerMovementView view)
    {
        movementView = view;
    }

    public void Move(Vector2 movementDirection)
    {
        movementView.Move(movementDirection);
    }
}