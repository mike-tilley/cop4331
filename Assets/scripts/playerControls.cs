using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;
    
    public float speed = 6f;

    public float turnTime = .1f;
    public float turnVelocity;
    private float maxSpeed = 10f; // mouse follow
    private Camera mainCamera; // mouse follow
    private Vector3 movedir;
    private Vector3 upandDown;
    private bool upKeyPressed = false;
    private bool downKeyPressed = false;
    
    

    // Update is called once per frame
    
    void Update()
    {
        mainCamera = Camera.current; // mouse follow
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        
        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;
        upandDown = new Vector3(horizontal, 0, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            //PointToMouse();
            //controller.Move(movedir.normalized * speed * Time.deltaTime);
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnVelocity, turnTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            movedir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(movedir.normalized * speed * Time.deltaTime);
            
            if (Input.GetKey(KeyCode.Q))
            {
                upKeyPressed = true;
                upandDown.y = speed;
                
            }
            if (Input.GetKey(KeyCode.E))
            {
                downKeyPressed = true;
                upandDown.y = -speed;
            }
            controller.Move(upandDown.normalized * speed * Time.deltaTime);

            upKeyPressed = false;
            downKeyPressed = false;
        }
        upKeyPressed = false;
        downKeyPressed = false;
        
    }// end update

}

