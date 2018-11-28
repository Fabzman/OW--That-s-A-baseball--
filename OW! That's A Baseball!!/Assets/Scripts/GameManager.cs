using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public int ballsHit;
    public TextMeshPro ballsHitText;

    private void Awake()
    {
        instance = this;
    }

    public void BallCounter()
    {
        ballsHit += 1;
        ballsHitText.text = "Balls Hit:" + ballsHit.ToString();
    }
}
