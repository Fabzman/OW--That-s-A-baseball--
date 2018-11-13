using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwing : MonoBehaviour {

    public float rotationSpeed = 10F;
    private float rotation;

    // Use this for initialization
    void Start ()
    {
        rotation = transform.eulerAngles.y;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rotation = -134F;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            rotation = 44F;
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.AngleAxis(rotation, Vector3.up), rotationSpeed * Time.deltaTime);
    }
}
