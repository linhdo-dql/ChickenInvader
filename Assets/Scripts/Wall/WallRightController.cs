using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRightController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // float xPlayer = Mathf.Abs(player.transform.position.x);
        // float yBullet = Mathf.Abs(other.transform.position.y);
        // float cosAlpha = xPlayer / yBullet;
        // float anpha = Mathf.Acos(cosAlpha);
        other.transform.Rotate(other.transform.rotation.x, -(90 - other.transform.rotation.y), other.transform.rotation.z);
    }
}
