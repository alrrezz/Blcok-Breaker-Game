using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float MinXInUnits = 0.8f;
    [SerializeField] float MaxXInUnits = 15.2f;
    [SerializeField] float ScreenWidthInUnits = 16f;

    //cashed Refrences
    Ball ball;
    GameStatus gameStatus;


    // Start is called before the first frame update
    void Start()
    {
        ball = FindObjectOfType<Ball>();
        gameStatus = FindObjectOfType<GameStatus>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePaddleWithMouse();
    }

    private void MovePaddleWithMouse()
    {
        Vector2 paddlePsotion = new Vector2(transform.position.x, transform.position.y);
        paddlePsotion.x = Mathf.Clamp(GetXPosition(), MinXInUnits, MaxXInUnits);   //limit x of paddle
        transform.position = paddlePsotion;
    }
    private float GetXPosition()
    {
        if (gameStatus.IsAutoplayOn())
        {
            return ball.transform.position.x;   //Auto Ball Position
        }
        else
        {
            return (Input.mousePosition.x / Screen.width) * ScreenWidthInUnits;  //Mouse X Position
        }
    }
}
