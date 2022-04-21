using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileBehavior : MonoBehaviour
{
    public GameObject bulliet;
    public float bulletSpeed = 50.0f;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }
     public void Fire()
    {
        bulliet.transform.Translate(0, -bulletSpeed * Time.deltaTime, 0);
    }

   




}
