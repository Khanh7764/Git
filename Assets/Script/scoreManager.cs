using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public Text scoreText; // Text Object ?? hi?n th? ?i?m s?
    private int score = 0; // Bi?n l?u tr? ?i?m s?

    // Hàm Update ???c g?i m?i khung hình
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bird")
        {
            //Debug.Log("+1");
            score++;
            scoreText.text = "Score: " + score;
            // Debug.Log("core = " + score);
        }
    }
    void Update()
    {

        // C?p nh?t n?i dung c?a Text Object
        //scoreText.text = "Score: " + score;
    }

    // Hàm này ???c g?i khi ng??i ch?i ??t ???c ?i?m
    /* public void AddScore(int points)
     {

         score += points; // T?ng ?i?m s? lên
     }*/
    

}
