using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public int ballsHit;
    public int baseballs;
    public TextMeshPro ballsHitText;
    public TextMeshPro baseballsText;

    private void Awake()
    {
        instance = this;
    }

    public void BallCounter()
    {
        ballsHit += 1;
        ballsHitText.text = "Balls Hit:" + ballsHit.ToString();
    }

    public void HitCounter()
    {
        baseballs += 1;
        baseballsText.text = "Baseballs:" + baseballs.ToString();
    }
}
