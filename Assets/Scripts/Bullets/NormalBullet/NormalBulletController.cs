using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBulletController : MonoBehaviour
{
    [SerializeField] public float movementSpeed = 20;

    [SerializeField] private float lifeTime = 5f;
    // Start is called before the first frame update
    private void Start()
    {
        gameObject.GetComponent<GameController>().DestroyObjAfterTime(gameObject, lifeTime);
    }
    // Update is called once per frame
    private void Update()
    {
        
    }
    
}
