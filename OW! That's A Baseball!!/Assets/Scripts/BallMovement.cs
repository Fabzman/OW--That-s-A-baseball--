using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

    public float ballSpeed;
    public float lifetime;
    //public Transform player;

    // Use this for initialization
    void Start ()
    {
        //player = GameObject.Find("Player").transform;
        lifetime = 5f;
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.forward * ballSpeed * Time.deltaTime);
        lifetime -= Time.deltaTime;

        if (lifetime <=0)
        {
            lifetime = 5f;
            Destroy(gameObject);
        }
    }
}
