using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour {

    public static BallSpawn instance;

    public int ballCount;
    public float spawnTimer;
    public GameObject ball;
    //public Transform ballSpawner;

    // Use this for initialization
    void Start()
    {
        spawnTimer = 2f;
        ballCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (ballCount >= 1)
        {
            return;
        }

        if (spawnTimer <= 0 && ballCount < 1)
        {
            Instantiate(ball, transform.position, transform.rotation);
            ballCount++;
            spawnTimer = 5f;
        }
    }
}
