using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildBulletController : MonoBehaviour
{
    public float lifeTime;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<GameController>().DestroyObjAfterTime(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
