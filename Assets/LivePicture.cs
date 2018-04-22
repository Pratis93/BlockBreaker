using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivePicture : MonoBehaviour
{
    private Transform trans;
    public Sprite[] lives;

   public void SetLivePicture()
    {
        this.GetComponent<SpriteRenderer>().sprite = lives[GameManager.live - 1];
    }




}
