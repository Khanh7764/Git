using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdController : MonoBehaviour
{
    public GameObject GameOver;
    public GameObject PlayAgain;
    public GameObject Beiu;
    public float flyPower; // Độ lớn của lực nâng
    private Rigidbody2D obj; // Tham chiếu đến Rigidbody2D của vật thể
    public Text scoreText;
    int score = 0;
    public AudioSource GameOverSound;
    public void Start()
    {
        
        flyPower = 300;
        obj = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0)) // Kiểm tra xem người chơi có nhấn chuột trái không
        {
            obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, flyPower));
           
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bird")
        {
            //Debug.Log("+1");
            score++;
            // Debug.Log("core = " + score);
            scoreText.text = "Score: " + score;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EndGame")
        {
            //End_Game.Play();
            //LoadLevel(name);
            //Application.LoadLevel(2);'
            GameOverSound.Play();
            Debug.Log("Khanh");
            GameOver.SetActive(true);
            PlayAgain.SetActive(true);
            Beiu.SetActive(true);
            Time.timeScale = 0;


        }

    }
    public void loadScene(string name)
    {
        Application.LoadLevel(0);
        Time.timeScale = 1;
    }
    public void LoadScene(string game)
    {
        Application.LoadLevel(0);
    }
}
