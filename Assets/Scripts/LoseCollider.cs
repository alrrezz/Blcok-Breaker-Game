using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{

    //GameStatus gameStatus;

    private void Start()
    {
        //gameStatus = FindObjectOfType<GameStatus>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
    
        int ballCount = FindObjectsOfType<Ball>().Length;
    /*
        if(ballCount <= 1)
        {
            gameStatus.MinusLives();
            GameObject newBall = Instantiate(ballPrefab)
        }
    
        if(gameStatus.HavingZeroLives())
        {
            SceneManager.LoadScene("Game Over");
        }
    */
        if (collision.CompareTag("Ball"))
        {
            ballCount--;

            if (ballCount <= 0)
            {
                SceneManager.LoadScene("Game Over");
            }
        }

        Destroy(collision.gameObject);
        
    }
}
