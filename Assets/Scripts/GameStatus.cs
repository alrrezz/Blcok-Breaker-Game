using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public class GameStatus : MonoBehaviour
{
    //config parameters
    [Range(0.1f , 10f)][SerializeField] float gameSpeed = 1.0f;
    [SerializeField] int scorePerBlock = 1;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] bool autoPlay = false;
    [SerializeField] int currentLevelIndex = 0; //------------ test for save game and won level scene -----------------
    //[Range(1 , 3)][SerializeField] int lives = 3;

    //State Variables
    [SerializeField] int currentScore;

//---------------------------------------------------------------------------------------------------

    private void Awake()
    {
        KeepGameStatusAlive();
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = currentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    //-----------------------------------------------------------------------------------------------

    private void KeepGameStatusAlive()
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;

        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void UpdateScore()
    {
        currentScore += scorePerBlock;
        scoreText.text = currentScore.ToString();
    }

    public void DestroyYourself()
    {
        Destroy(gameObject);
    }

    public bool IsAutoplayOn()
    {
        return autoPlay;
    }

    public void PlusCurrentLevelIndex() //-----------------test--------------------------
    {
        currentLevelIndex++;
    }

    public int GetCurrentLevelIndex() //-------------------test--------------------------
    {
        return currentLevelIndex;
    }


 /*   public bool HavingZeroLives()
    {
        if (lives <= 0)
        {
            return true; 
        }
        return false;
    }
    public void MinusLives()
    {
        lives--;
    }
    public void PlusLives() 
    {
        if(lives <= 2)
        {
            lives++;
        }
    }
 */
}
