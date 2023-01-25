using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
             Debug.Log("Helo Word!!");
         }
         SetScore();
         
     }
     void SetScore()
     {
         ScoreText.text = string.Format("現在の点数:{0}", score);
     }
}