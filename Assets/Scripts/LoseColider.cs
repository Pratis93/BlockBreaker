using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseColider : MonoBehaviour
{
    private LevelManager levelmenager;
    private BasketBall ball;
    private PaddleScript padle;
    private SoundManager sound;
    private LivePicture livep;

    private void Awake()
    {
        ball = GameObject.FindObjectOfType<BasketBall>();
        padle = GameObject.FindObjectOfType<PaddleScript>();
        levelmenager = GameObject.FindObjectOfType<LevelManager>();
        sound = GameObject.FindObjectOfType<SoundManager>();
        livep = GameObject.FindObjectOfType<LivePicture>();
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        sound.PlayLostLife();
        GameManager.live--;


        if (GameManager.live <= 0)
        {
            levelmenager.SceneGameOver();
        }else
        {
            livep.SetLivePicture();
            BasketBall.gameStart = false;
        }
        
    }

  

}
