using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{


    [SerializeField] GameObject ballPrefab;

    Ball[] balls;

    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        balls = FindObjectsOfType<Ball>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Paddle"))
        {
            Destroy(gameObject);

            if (CompareTag("BallX2Item"))
            {
                foreach (Ball ball in balls)
                {
                    ball.AddBall();
                }
            }
        }
    }
}
