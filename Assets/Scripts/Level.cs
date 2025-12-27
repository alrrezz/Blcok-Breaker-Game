using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    //config parametes
    [SerializeField] int breakableBlocks;   //for Debugging

    //chashed refrences
    SceneLoader sceneLoader;
    GameStatus gameStatus; //----------------------------test-----------------------------

    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
        gameStatus = FindObjectOfType<GameStatus>(); //--test-----------------------------
    }

    public void BlockBreaked()
    {
        breakableBlocks --;

        if (breakableBlocks <= 0) 
        {
            gameStatus.PlusCurrentLevelIndex(); //-------tset-----------------------------
            sceneLoader.LoadNextScene();


            //gameStatus.MinusLives();
        }

        //Debug.Log(breakableBlocks); //-------------------Test-----------------------
    }
    public void CountBlocks()
    {
        breakableBlocks++;

        //Debug.Log(breakableBlocks); //---------------------Test-------------------------
    }

}
