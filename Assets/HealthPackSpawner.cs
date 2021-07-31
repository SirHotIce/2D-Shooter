using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPackSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject heathPack;
    public int playerYPos;
    private GameObject player;
    private bool isSpawned=false;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y >= playerYPos && !isSpawned)
        {
            int x = Random.Range(-7, 7);
            Vector3 position = new Vector3(x, playerYPos + 30, player.transform.position.z);
            Instantiate(heathPack, position, heathPack.transform.rotation);
            isSpawned = true;
        }
    }
}
