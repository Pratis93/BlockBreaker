using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{

   enum indexOfLevel
    {
       mainMenu =0,
       level_01=1,
       gameOver=2,
       win=3
    }



    public void SceneMainMenu()
    {
        SceneManager.LoadScene((int)indexOfLevel.mainMenu);
    }
    public void SceneLevel_01()
    {
        BasketBall.gameStart = false;
        GameManager.live = 3;
        SceneManager.LoadScene((int)indexOfLevel.level_01);
    }

    public void SceneGameOver()
    {
        SceneManager.LoadScene((int)indexOfLevel.gameOver);
    }

    public void SceneWin()
    {
        SceneManager.LoadScene((int)indexOfLevel.win);
    }
}
