using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void FullScreen()
    {
        Screen.fullScreen = !Screen.fullScreen;

    }

    public void Credits()
    {
        SceneManager.LoadScene(4);

    }

    public void Exit()
    {
        Application.Quit();

    }
}
