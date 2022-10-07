 using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class InitEnemy : MonoBehaviour
{
    public float enemyStartZPoint;
    public float xRange;
    public GameObject enemy;
    public float enemyInitInterval = 0.2f;
    private float _enemyInitElapsedTime;
    private void Start()
    {
        
    }

    private void Update()
    {
        if (_enemyInitElapsedTime < 0)
        {
            var v = new Vector3(Random.Range(-xRange, xRange), 0.5f, enemyStartZPoint);
            gameObject.GetComponent<GameController>().InstantiateObj(enemy, v);
            _enemyInitElapsedTime = enemyInitInterval;
        }

        _enemyInitElapsedTime -= Time.deltaTime;
    }
}
