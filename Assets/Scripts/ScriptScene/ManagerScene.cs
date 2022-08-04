using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoBehaviour
{

	int index;

	void Start()
    {
		index = PlayerPrefs.GetInt("CurrentScene");
	}

	public  void LoadExit()
	{
		SceneManager.LoadScene(0);
	}


	public  void LoadNewsScene()
	{
		SceneManager.LoadScene(1);
	}


	public  void LoadSettings()
	{
		SceneManager.LoadScene(2);
	}


	public  void LoadSelectScene()
	{
		SceneManager.LoadScene(3);
	}


	public  void LoadFirstLevel()
	{
		PlayerPrefs.DeleteAll();
		SceneManager.LoadScene(4);
	}

	
	public  void LoadProceed()
	{
		SceneManager.LoadScene(index);
	}


	public  void ExitGame()
	{
		Application.Quit();
	}

}
