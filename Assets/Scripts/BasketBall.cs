using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketBall : MonoBehaviour {

    private Rigidbody2D rigi;
    private bool colison = false;
    private PaddleScript padle;

    public static bool gameStart=false;

    private void Awake()
    {
        rigi = GetComponent<Rigidbody2D>();
        padle = GameObject.FindObjectOfType<PaddleScript>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rigi.velocity += new Vector2(Random.Range(0f, 0.2f), Random.Range(0f, 0.2f)); 
    }
    public void StartGame()
    {
        if(!gameStart)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                rigi.velocity = new Vector2(1f, 4f);
                gameStart = true;
            }
        }
    }
    public void ColisionFromPaddle()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigi.velocity = new Vector2(rigi.velocity.x + 1f, rigi.velocity.y);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigi.velocity = new Vector2(rigi.velocity.x - 1f, rigi.velocity.y);
        }
    }
   
    void GameNotStart()
    {
        this.transform.position = new Vector3(padle.transform.position.x, padle.transform.position.y + 0.253f, 0f);
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        BasketBall.gameStart = false;
    }

    private void Update()
    {
        StartGame();
        if(!gameStart)
        {
            GameNotStart();
        }
       
    }
}
