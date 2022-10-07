using System;
using UnityEngine;

public class KeepInsideScreen : MonoBehaviour
{
    public float xRange = 4.3f;
    private void Start()
    {
        
    }

    private void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
