using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripperBulletController : MonoBehaviour
{
    public GameObject lBullet;
    public GameObject cBullet;
    public GameObject rBullet;
    public void InitBullet()
    {
        gameObject.GetComponent<GameController>().InstantiateObj(lBullet,transform.position);
        gameObject.GetComponent<GameController>().InstantiateObj(rBullet,transform.position);
        gameObject.GetComponent<GameController>().InstantiateObj(cBullet,transform.position);
    }
    
    
}
