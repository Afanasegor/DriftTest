using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    [SerializeField] private float movementPower = 2000f;
    [SerializeField] private float rotationPower = 500f;

    [Space]
    [SerializeField] private float velocityLimit = 500f;
    //[SerializeField] private float torgueLimit = 1000f;

    private bool moveForward, moveBack, moveLeft, moveRight = false;
    

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (/*Input.GetKey(KeyCode.A) ||*/ moveLeft)
            rb.AddTorque(Vector3.down * rotationPower * Time.deltaTime, ForceMode.Acceleration);
        else if (/*Input.GetKey(KeyCode.D) ||*/ moveRight)
            rb.AddTorque(Vector3.up * rotationPower * Time.deltaTime, ForceMode.Acceleration);
        else if (/*Input.GetKey(KeyCode.W) || */moveForward)
            rb.AddForce(transform.forward * movementPower * Time.deltaTime, ForceMode.Acceleration);
        if (/*Input.GetKey(KeyCode.S) || */moveBack)
            rb.AddForce(-transform.forward * movementPower * Time.deltaTime, ForceMode.Acceleration);

        rb.velocity = new Vector3(
            Mathf.Clamp(rb.velocity.x, -velocityLimit, velocityLimit),
            Mathf.Clamp(rb.velocity.y, -velocityLimit, velocityLimit),
            Mathf.Clamp(rb.velocity.z, -velocityLimit, velocityLimit));        
    }

    public void MoveLeft()
    {
        if (moveLeft)
        {
            moveLeft = false;
        }
        else
        {
            moveLeft = true;
        }
    }
    public void MoveRight()
    {
        if (moveRight)
        {
            moveRight = false;
        }
        else
        {
            moveRight = true;
        }
    }
    public void MoveBack()
    {
        if (moveBack)
        {
            moveBack = false;
        }
        else
        {
            moveBack = true;
        }
    }
    public void MoveForward()
    {
        if (moveForward)
        {
            moveForward = false;
        }
        else
        {
            moveForward = true;
        }
    }
}
