using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapult : MonoBehaviour
{
    public float rotateSpd = 2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(0, rotateSpd, 0);
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(0, -rotateSpd, 0);

    }
}
