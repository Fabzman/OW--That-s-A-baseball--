using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

    public float ballSpeed;
    public float lifetime;

    private Rigidbody rb;
    private TrailRenderer trail;
    public AudioClip hit;

    //public Transform player;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(transform.forward * ballSpeed, ForceMode.Impulse);

        trail = GetComponent<TrailRenderer>();
    }

    // Use this for initialization
    void Start ()
    {
        //player = GameObject.Find("Player").transform;
        trail.enabled = false;
        lifetime = 5f;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //transform.Translate(Vector3.forward * ballSpeed * Time.deltaTime);
        lifetime -= Time.deltaTime;

        if (lifetime <=0)
        {
            lifetime = 5f;
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Bat"))
        {
            rb.constraints = RigidbodyConstraints.None;
            rb.AddForce(collision.contacts[0].normal * ballSpeed * 10, ForceMode.Impulse);
            trail.enabled = true;
            AudioSource.PlayClipAtPoint(hit, Camera.main.transform.position);
            GameManager.instance.BallCounter();
        }
    }
}
