using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerModel playerModel;
    private PlayerView playerView;
    private PlayerMovementModel movementModel;
    private PlayerMovementView movementView;

    public void InitializeMovement(PlayerModel model, PlayerView view)
    {
        playerModel = model;
        playerView = view;
        playerModel.OnHealthChange += OnHealthChange;
        playerModel.OnPlayerDeath += OnPlayerDeath;

        movementModel = new PlayerMovementModel();
        movementView = GetComponent<PlayerMovementView>();
        movementModel.Initialize(movementView);

        PlayerMovementController movementController = GetComponent<PlayerMovementController>();
        movementController.Initialize(movementModel, movementView);
    }

    public void Initialize(PlayerModel model, PlayerView view)
    {
        playerModel = model;
        playerView = view;
        playerModel.OnHealthChange += OnHealthChange;
        playerModel.OnPlayerDeath += OnPlayerDeath;
    }

    private void OnHealthChange(int health)
    {
        playerView.UpdateHealthText(health);
    }

    private void OnPlayerDeath()
    {
        Destroy(gameObject);
    }
}