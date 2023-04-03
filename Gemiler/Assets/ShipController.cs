using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{

    public DynamicJoystick dynamicJoystick;

    string boatName;

    public float speed = 5f;
    public float turnSpeed = 5f;
    float horizontal;
    float vertical;

    Rigidbody rb;

    void Start()
    {


        boatName = gameObject.name;
        if (boatName == "Boat1")
        {

        }
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }

    private void FixedUpdate()
    {
        MoveShip();
        
    }

    void MoveShip()
    {
        horizontal = dynamicJoystick.Horizontal;
        vertical = dynamicJoystick.Vertical;
        Vector3 hareketPos = new Vector3(horizontal * speed * Time.deltaTime, 0, vertical * speed * Time.deltaTime);
        transform.position += hareketPos;
        

        Vector3 donme = Vector3.forward *  -horizontal + Vector3.right * vertical;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(donme), turnSpeed * Time.deltaTime);

    }
}
