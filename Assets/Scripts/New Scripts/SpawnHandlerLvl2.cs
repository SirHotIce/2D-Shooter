using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHandlerLvl2 : MonoBehaviour
{
    private int whenPlayerCrossesY;
    private int whenPlayerCrossesX;
    private int whenPlayerStaysWithinX;
    public int howManyToSpawn;
    private GameObject player;
    private EnemySpawner eSP;
    // Start is called before the first frame update
    void Start()
    {
        eSP = gameObject.GetComponent<EnemySpawner>();
        player = GameObject.Find("Player");
        whenPlayerCrossesY = (int)(this.gameObject.transform.position.y - 20.0f);
        whenPlayerCrossesX = (int)(this.gameObject.transform.position.x - 20.0f);
        whenPlayerStaysWithinX = whenPlayerCrossesX + 50;
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if((player.transform.position.y>= whenPlayerCrossesY)&& (player.transform.position.x >= whenPlayerCrossesX) && (player.transform.position.x <= whenPlayerStaysWithinX))
        {
            gameObject.active = true;
            eSP.maxSpawn = howManyToSpawn;
            
        }
    }
}
