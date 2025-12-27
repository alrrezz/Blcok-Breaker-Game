using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] float loadDelayInSeconds = 2f;
    //int currentLevel = 0; //----------------------------------------------------------------
                            //the problem is "currentlevel" gets destroyed every time
                            //and it became 0 so we'll back to fist scene every time
    public void LoadNextScene()
    {
        //StartCoroutine(WaitAndLoad());//--------------------------Test----------------------
        int CurrentScene = SceneManager.GetActiveScene().buildIndex;

        //currentLevel = +1; //---------------------------------------------------------------

        SceneManager.LoadScene(CurrentScene + 1);
    }

    public void LoadrStartScene()
    {
        SceneManager.LoadScene(0);
        if(FindObjectsOfType<GameStatus>().Length > 0)
        {
            FindObjectOfType<GameStatus>().DestroyYourself();
        }
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadCredditScene()
    {
        SceneManager.LoadScene("Creddit");
    }

    public void LoadGameOverScene()
    {
        //StartCoroutine(WaitAndLoad());//------------------------Test-------------------------
        SceneManager.LoadScene("Game Over");
    }

    //public void LoadLevelWonScene()
    //{
    //    SceneManager.LoadScene("LevelWon");
    //}

    //public void LoadLastLevel() //------------------------------Test-------------------------
    //{
    //    SceneManager.LoadScene(currentLevel);
    //}

    //private IEnumerator WaitAndLoad()
    //{
    //    yield return new WaitForSeconds(loadDelayInSeconds);
    //}
}
