using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ceglaScript : MonoBehaviour {

    public int livesOfBrick;
    public Sprite[] spriteOfBrick;
    private SoundManager music;

    private GameManager game;

    private void Awake()
    {
        music = GameObject.FindObjectOfType<SoundManager>();
        game = GameObject.FindObjectOfType<GameManager>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (livesOfBrick<=1)
        {
            music.PlayDestroy();
            Destroy(gameObject);

        }else
        {
            music.PlayHit();
            livesOfBrick--;
            if (spriteOfBrick[livesOfBrick - 1] == null) return;
            this.GetComponent<SpriteRenderer>().sprite = spriteOfBrick[livesOfBrick-1];
        }
    }
   

}
