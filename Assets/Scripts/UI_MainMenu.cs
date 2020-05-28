using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_MainMenu : MonoBehaviour
{
    [SerializeField] private string MainGame = "";
    [SerializeField] private string TestScene = "";


    private void Start()
    {
        if (MainGame == "" )
        {
            Debug.LogError("ERROR - In UI_MainMenu script the MainGame scene is not assigned");
        }
        if (TestScene == "")
        {
            Debug.LogError("ERROR - In UI_MainMenu script the TestScene scene is not assigned");
        }
    }

    public void buttonStartGameMain()
    {
        SceneManager.LoadScene(MainGame);
    }

    public void buttonOptions()
    {
        Debug.Log("This should open the options later!");
    }

    public void buttonTestScene()
    {
        SceneManager.LoadScene(TestScene);
    }
    public void buttonQuitGame()
    {
        Application.Quit();
    }
}
