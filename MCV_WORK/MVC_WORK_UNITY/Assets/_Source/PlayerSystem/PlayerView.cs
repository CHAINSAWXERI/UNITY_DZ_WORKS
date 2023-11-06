using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;

public class PlayerView : MonoBehaviour
{
    public TMP_Text healthText;
    public PlayerModel model;

    public void Start()
    {
        healthText.text = "Health: " + model.maxHealth.ToString();
    }

    public void UpdateHealthText(int health)
    {
        healthText.text = "Health: " + health.ToString();
    }
}
