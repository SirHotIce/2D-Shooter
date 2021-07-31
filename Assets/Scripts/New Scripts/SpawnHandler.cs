using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHandler : MonoBehaviour
{
    public int whenPlayerCrosses;
    public int howManyToSpawn;
    private GameObject player;
    private EnemySpawner eSP;
    // Start is called before the first frame update
    void Start()
    {
        eSP = gameObject.GetComponent<EnemySpawner>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if(player.transform.position.y>= whenPlayerCrosses)
        {
            gameObject.active = true;
            eSP.maxSpawn = howManyToSpawn;
            
        }
    }
}
