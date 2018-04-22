using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public BasketBall ball;
    public PaddleScript paddle;

    public static int live = 3;

    public LevelManager level;

    public float speedofPadle = 0.1f; 

	// Use this for initialization
	void Start ()
    {
        float paddleX = paddle.transform.position.x;
        ball.transform.position = new Vector3(paddleX, -0.472f, 0f);
    }

    private void HandleKey()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 position = paddle.transform.position;
            Vector3 dir = new Vector3(-speedofPadle, 0, 0);

            Vector3 resoult = dir + position;

            if (resoult.x < 1.215f) resoult.x = 1.215f;

            if (!BasketBall.gameStart)
            {
                ball.transform.position = new Vector3(resoult.x, ball.transform.position.y, 0f);
            }

            paddle.transform.position = resoult;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 position = paddle.transform.position;
            Vector3 dir = new Vector3(speedofPadle, 0, 0);

            Vector3 resoult = dir + position;

            if (resoult.x > 7.534f) resoult.x = 7.534f;

            if (!BasketBall.gameStart)
            {
                ball.transform.position = new Vector3(resoult.x, ball.transform.position.y, 0f);
            }

            paddle.transform.position = resoult;
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            level.SceneLevel_01();
        }
    }

    private void Update()
    {
        HandleKey();


        var lista = GameObject.FindGameObjectsWithTag("cegla");
        if (lista.Length == 0)
        {
            level.SceneWin();
        }
    }
}
