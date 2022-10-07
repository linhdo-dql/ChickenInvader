using System;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float movementSpeed = 20f;
    private void Start()
    {
      
    }

    private void Update()
    {
        transform.Translate(Time.deltaTime * movementSpeed * Vector3.forward);
    }
}
