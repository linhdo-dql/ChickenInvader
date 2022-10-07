using System;
using UnityEngine;

public class DoubleBulletController : MonoBehaviour
{
    public float lifeTime;
    private void Start()
    {
        gameObject.GetComponent<GameController>().DestroyObjAfterTime(gameObject, lifeTime);
    }
}
