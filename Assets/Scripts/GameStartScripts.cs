using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonPushGameStart()
    {
       SceneManager.LoadScene("SampleScene");
       Debug.Log("HeloWorld!!");
    }
    public void ButtonPushAplecationQuit()
    {
      Application.Quit();
      Debug.Log("HeloWorld!!");
    }
}