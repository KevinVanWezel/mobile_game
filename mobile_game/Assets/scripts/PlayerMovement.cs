using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Rigidbody _rigidbody;
    private Vector3 _inputDirection;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();


    }
   
    void Update()
    {


        if (Input.GetKeyDown("space"))
        {
            transform.Translate(Vector3.up * 50 * Time.deltaTime, Space.World);
        }
       
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        _inputDirection = new Vector3(x, 0f, z);


    }
    void FixedUpdate()
    {
       
        _rigidbody.AddForce(_inputDirection * speed);
    }
   

   
}