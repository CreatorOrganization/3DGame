using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WindowTitleScripts : MonoBehaviour
{
    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */
    public void WindowTitle()
    {
        SceneManager.LoadScene("WindowTitle"); //ここにButtonを押したときに画面遷移をしてほしいScene名を書いてください
    }
    public void ApplecationQuit()
    {
        Application.Quit();
    }

    public void WindowBAck()
    {
        SceneManager.LoadScene("Scenes/SampleScene");
    }

    public void Taitle()
    {
        SceneManager.LoadScene("WindowTitle");
    }

}
