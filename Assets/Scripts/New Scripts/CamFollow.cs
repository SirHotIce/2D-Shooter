using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    private GameObject theCamera;
    private GameObject thePlayer;
    // Start is called before the first frame update
    void Awake()
    {
        theCamera = this.gameObject;
        thePlayer = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camLocation = new Vector3(thePlayer.transform.position.x, thePlayer.transform.position.y, theCamera.transform.position.z);
        theCamera.transform.position = camLocation;
    }
}
