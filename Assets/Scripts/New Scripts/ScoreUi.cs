using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUi : UIelement
{
    private GameObject player;
    public Text LivesDisplay;
    public Text HealthDisplay;
    private Health playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerHealth = player.GetComponent<Health>();

    }
    private void Update()
    {
        base.UpdateUI();
        LivesDisplay.text = $"x{playerHealth.currentLives}";
        HealthDisplay.text = $"x{playerHealth.currentHealth}";

    }
    
}
