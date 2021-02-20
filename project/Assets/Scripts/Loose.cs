using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Loose : MonoBehaviour
{
    //static public int score;
    //static public bool finish=false;
    public float spawnX, spawnY;
    public GameObject myText;
    private int score;
    GameState foo = GameState.getInstance();

    private void Start()
    {

        spawnX = transform.position.x;
        spawnY = transform.position.y;
        gameObject.GetComponent<AudioSource>().volume = MainMenu.MusicActive;
        foo.setFinish(false);
        //finish = false;
        score = 0;
    }
   
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Coin")//Если имя объекта с которым мы столкнулись Coin,удаляем его и прибавляем очки
        {
            Sound.PlaySound("coin");
            Destroy(other.gameObject);
            score++;
            foo.setScore(score);
            myText.GetComponent<UnityEngine.UI.Text>().text = "" + foo.getScore();
        }

        if (other.gameObject.tag == "Finish")
        {
            Sound.PlaySound("coin");
            Destroy(other.gameObject);
            foo.setFinish(true);
            //finish = true;
        }
       
        if (other.gameObject.tag == "CheckPoint")//При столкновении с чекпоинтом 
        {
            
            spawnX = transform.position.x;//Сохраняем новую позицию
            spawnY = transform.position.y;
            Sound.PlaySound("Finish");
        }
    }

    private void OnCollisionEnter2D(Collision2D col)//При столкновении 
    {

        if (col.gameObject.tag == "saw" || col.gameObject.tag== "boundariesLower")
        {
            Sound.PlaySound("gameover");
            transform.position = new Vector3(spawnX, spawnY, transform.position.z);

        }
        if (col.gameObject.tag == "Bomb")//Если бомба коснулась игрока 
        {
            Sound.PlaySound("explosion");
            transform.position = new Vector3(spawnX, spawnY, transform.position.z);//возврат на старт. поз.
        }
    }

    

}
