using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointConter : MonoBehaviour
{

    public Text ScoreText;
    private int score = 0;
    
     void Start()
     {
         score = 0;
         SetScore(); //スコア計算用代入して表示
     }

     private void OnCollisionEnter(Collision collision)
     {
         string yourTag = collision.gameObject.tag;
         if (yourTag == "Player")
         {
             score += 10;
         }
         else
         {
             score += 5;
         }
         SetScore();
     }

     void SetScore()
     {
         ScoreText.text = string.Format("現在の点数:{0}", score);
     }
}