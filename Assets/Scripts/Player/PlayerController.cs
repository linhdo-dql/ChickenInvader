using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 20f;
    // Start is called before the first frame update
    public Transform bulletStartPos;
    public GameObject bullet;
    
    private float _bulletElapsedTime;
    public float bulletIntervalTime = 0.4f;
    public GameObject[] bulletList;
    private int i;
    private Vector3 lastPostion;
    public float currentHp;
    public float maxHp;
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            i = i < bulletList.Length -1 ? i+1 : 0;
            bullet = bulletList[i];
        }
        
        if (_bulletElapsedTime <= 0)
        {
            InitBullet(bullet);
            _bulletElapsedTime = bulletIntervalTime;
        }
        _bulletElapsedTime -= Time.deltaTime;
        
        
        transform.Translate(movementSpeed * Time.deltaTime * Input.GetAxis("Horizontal") * Vector3.right);
    }
    
    
    private void InitBullet(GameObject bulletObj)
    {
        gameObject.GetComponent<GameController>().InstantiateObj(bulletObj, bulletStartPos.position);
    }

    public void UpdateHp(int hp)
    {   
        Debug.Log("Chạy");
        if (currentHp <= maxHp)
        {
            currentHp += hp;
        }
        if (currentHp < 0)
        {
            Debug.Log("Game over");
        }
    }

    
}
