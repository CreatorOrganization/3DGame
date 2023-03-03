using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointConter : MonoBehaviour
{
    public Text ScoreText;
    private int score = 0;
    private GameObject gameObj;
     void Start()
     {
         score = 0;
         SetScore(); //スコア計算用代入して表示
     }

     private void OnCollisionEnter(Collision collision)
     {
         if (transform.gameObject.tag == "Player" && collision.gameObject.CompareTag("Finish"))
         {
             score += 10;
         }
         SetScore();

         if(transform.gameObject.tag == "EditorOnly")
         {
            score += 30;
         }
         SetScore();
         if (transform.gameObject.tag == "Respawn")
         {
             score += 5;
         }
         SetScore();
         if (collision.gameObject.tag == "point")
         {
             score += 3;
         }
         SetScore();
         if (score >=20)
         {
             SceneManager.LoadScene("GOALWindow");
         }
     }
     
     void SetScore()
     {
         ScoreText.text = string.Format("EnableScore:{0}", score);
     }
}