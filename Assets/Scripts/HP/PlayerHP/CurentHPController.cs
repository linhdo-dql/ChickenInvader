using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurentHPController : MonoBehaviour
{
    public GameObject player;

    private float distanceHp = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distanceHp =
            player.GetComponent<PlayerController>().currentHp /
            player.GetComponent<PlayerController>().maxHp;
        float downHp = 
            (player.GetComponent<PlayerController>().maxHp - player.GetComponent<PlayerController>().currentHp) /
            player.GetComponent<PlayerController>().maxHp;
        if (distanceHp  >= 0)
        {
            transform.localScale = new Vector3(distanceHp, transform.localScale.y, transform.localScale.z);
            transform.position = new Vector3(player.transform.position.x - downHp/2, transform.position.y, transform.position.z);
        }
       
    }
}
