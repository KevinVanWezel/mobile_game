using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectsMoving : MonoBehaviour
{

    private Rigidbody rb;
    public Vector3 userDirection = Vector3.right;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        transform.position += userDirection * 4 * Time.deltaTime;
    }
    private void OnCollisionEnter(Collision other)
    {
        {
            if (other.collider.CompareTag("walls"))
            {
                if (userDirection == Vector3.left)
                {
                    userDirection = Vector3.right;
                }
                else
                {
                    userDirection = Vector3.left;
                }
            }



        }
    }
}
