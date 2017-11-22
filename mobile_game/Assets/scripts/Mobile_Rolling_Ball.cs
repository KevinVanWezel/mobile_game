// iOS gyroscope example
//
// Create a cube with camera vector names on the faces.
// Allow the iPhone to show named faces as it is oriented.

using UnityEngine;

public class Mobile_Rolling_Ball : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // make a quad for one side of the cube
    protected void Update()
    {
        Input.gyro.enabled = true;
        //GyroModifyBall();
    }
    

    /********************************************/

    // The Gyroscope is right-handed.  Unity is left handed.
    // Make the necessary change to the camera.
    void GyroModifyBall()
    {
        rb.AddForce(GyroToForce(Input.gyro.attitude));
    }

    private Vector3 GyroToForce(Quaternion q)
    {
        return new Vector3(q.x, q.y, -q.z);
    }
}