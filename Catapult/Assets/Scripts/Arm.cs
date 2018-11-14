using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arm : MonoBehaviour {

    public float rotateSpd = 5f;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Rotate(0, 0 , rotateSpd);
        if (Input.GetKey(KeyCode.S))
            transform.Rotate(0, 0, -rotateSpd);

    }
}
