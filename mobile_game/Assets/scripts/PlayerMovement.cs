using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private PlayerInput _input;
    private Rigidbody _rigidbody;
    private Vector3 _inputDirection;

    void Start()
    {
        _input = GetComponent<PlayerInput>();
        _rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float x = _input.getXspeed();
        float z = _input.getZspeed();
        _inputDirection = new Vector3(x, 0f, z).normalized;
    }
    void FixedUpdate()
    {
        _rigidbody.AddForce(_inputDirection * speed);
    }
   
    
   
}