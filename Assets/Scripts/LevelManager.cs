using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public void LoadLevel(string name)


    {
        Debug.Log("Level Load Requested for: " + name);
        SceneManager.LoadScene(name);
    }


    public void QuitLevel()
    {
        Debug.Log("Quiting Level");
        Application.Quit();
    }
    public void StartMenu()
    {
        SceneManager.LoadScene("Start");
    }

    public void Level01()
    {
        SceneManager.LoadScene("Level01");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Lose()
    {
        SceneManager.LoadScene("Lose");
    }
	public void Win()
	{
		SceneManager.LoadScene("Win");
	}


}