using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyController : MonoBehaviour
{
    public float enemyMovementSpeed = 2f;
    public float[] scaleSize;
    public float lifeTime;
    public float enemyBulletInterval;
    private float _enemyBulletElapsedTime;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(Random.Range(scaleSize[0], scaleSize[1]), transform.localScale.y, Random.Range(scaleSize[0], scaleSize[1]));
        gameObject.GetComponent<MeshRenderer>().material.color = ColorUtils.GetRandomColor();
        gameObject.GetComponent<GameController>().DestroyObjAfterTime(gameObject, lifeTime);
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * enemyMovementSpeed * Time.deltaTime);
        if (_enemyBulletElapsedTime < 0)
        {
            InitBullet();
            _enemyBulletElapsedTime = enemyBulletInterval;
        }

        _enemyBulletElapsedTime -= Time.deltaTime;
    }


    private void OnTriggerEnter(Collider other)
    {
        string nameTag = other.tag;
        switch (nameTag)
        {
            case "NormalBullets" : Destroy(gameObject);
                break;
            case "TripperBullet" :  Destroy(gameObject);
                other.gameObject.GetComponent<TripperBulletController>().InitBullet();
                Destroy(other.gameObject);
                break;
            
            case "DoubleBullet" : 
                Destroy(gameObject);
                Destroy(other.gameObject);
                break;
            case "Player":
                Destroy(gameObject);
                GameObject player = GameObject.Find("Player");
                player.GetComponent<PlayerController>().UpdateHp(-1);
               break;
        }
    }

    public void InitBullet()
    {
       
        gameObject.GetComponent<GameController>().InstantiateObj(bullet, transform.position);
    }
}
