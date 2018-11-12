using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour {

    public static BallSpawn instance;

    public float spawnTimer;
    public GameObject ball;
    //public Transform ballSpawner;
    private GameObject currentBall;
    // Use this for initialization
    void Start()
    {
        spawnTimer = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (currentBall)
        {
            return;
        }

        if (spawnTimer <= 0)
        {
            currentBall = Instantiate(ball, transform.position, transform.rotation);
            spawnTimer = 5f;
        }
    }
}
