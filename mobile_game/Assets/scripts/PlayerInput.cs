using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {
    [SerializeField]
    private bool touch;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public float getXspeed()
    {
        if (touch)
        {
            return 0.0f;
        }
        else
        {
            return Input.GetAxis("Horizontal");
        }
    }
    public float getZspeed()
    {
        if (touch)
        {
            return 0.0f;
        }
        else
        {
            return Input.GetAxis("Vertical");
        }
    }
}
