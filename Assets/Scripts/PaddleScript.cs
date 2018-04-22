using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public BasketBall basket;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        basket.ColisionFromPaddle();
    }

}
