using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartRotate : MonoBehaviour
{
    private float z;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        gameObject.transform.Rotate(0, 0, 10 * Time.deltaTime);
        //Debug.Log($"{gameObject.transform.rotation}");

    }
}
