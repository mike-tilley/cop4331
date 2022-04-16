using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereMovement : MonoBehaviour
{
    float i, j, k;
    float horizontalSpeed = 6f;
    float verticalSpeed = 6f;
    float zSpeed = 6f;
    Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the mouse delta. This is not in the range -1...1
        i = horizontalSpeed * Input.GetAxis("Mouse X");
        j = verticalSpeed * Input.GetAxis("Mouse Y");
        k = zSpeed * Input.GetAxis("Mouse Z");
        position.x = i;
        position.y = j;
        position.z = k;
        transform.SetPositionAndRotation(position, Quaternion.identity);
    }
}
