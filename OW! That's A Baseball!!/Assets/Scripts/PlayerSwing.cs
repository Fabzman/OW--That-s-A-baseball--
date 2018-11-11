using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwing : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Rotate(0f, -180f, 0f);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.Rotate(0f, 180f, 0f);
        }

    }
}
