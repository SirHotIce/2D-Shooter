using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    private Collider2D playerCollider;
    private Health playerHealth;
    void Start()
    {
        player = GameObject.Find("Player");
        playerCollider = player.GetComponent<PolygonCollider2D>();
        playerHealth = player.GetComponent<Health>();
    }

  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == playerCollider)
        {
            playerHealth.currentHealth++;
            Destroy(this.gameObject);
        }
        
    }
}
