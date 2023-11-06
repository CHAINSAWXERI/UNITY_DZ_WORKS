using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBootstrapper : MonoBehaviour
{
    public GameObject playerPrefab;
    public Transform playerSpawnPoint;

    private void Start()
    {
        PlayerModel playerModel = new PlayerModel(100);
        GameObject playerObject = Instantiate(playerPrefab, playerSpawnPoint.position, Quaternion.identity);
        PlayerView playerView = playerObject.GetComponent<PlayerView>();
        PlayerController playerController = playerObject.GetComponent<PlayerController>();

        playerController.Initialize(playerModel, playerView);
    }
}
