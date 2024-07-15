using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Camera cam;
    public float camVelosity;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update method");
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W");
            transform.position += Vector3.forward * camVelosity;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S");
            transform.position += Vector3.back * camVelosity;
        }
    }
}
