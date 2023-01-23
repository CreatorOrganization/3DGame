using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScripts : MonoBehaviour
{
    // Inspecterで値を変更する
    private float spring = 40000;
    private float openAngle = 15; // 開く角度
    private float closeAngle = 0; // 閉じる角度

    // Hinge Joint
    private HingeJoint hjL; // AxisL
    private HingeJoint hjR; // AxisR

    // JointSpring
    private JointSpring jL; // AxisL
    private JointSpring jR; // AxisR

    void Start()
    {
        // AxisLとAxisRを探す
        GameObject flipperL = GameObject.Find("AxisL");
        GameObject flipperR = GameObject.Find("AxisR");

        // HingeJointを受け取る
        hjL = flipperL.GetComponent<HingeJoint>();
        hjR = flipperR.GetComponent<HingeJoint>();

        // Springを受け取る
        jL = hjL.spring;
        jR = hjR.spring;
    }

    void Update()
    {
        // 左クリックを押す
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            jL.spring = spring;
            jL.targetPosition = -openAngle;
            hjL.spring = jL;

        }
        if(Input.GetKeyUp(KeyCode.LeftArrow))  // 左クリックを離す
        {
            jL.spring = spring;
            jL.targetPosition = closeAngle;
            hjL.spring = jL;
        }
        // 右クリックを押す
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            jR.spring = spring;
            jR.targetPosition = openAngle;
            hjR.spring = jR;
        }
         if(Input.GetKeyUp(KeyCode.RightArrow))// 右クリックを離す
        {
            jR.spring = spring;
            jR.targetPosition = closeAngle;
            hjR.spring = jR;
        }
    }   
}