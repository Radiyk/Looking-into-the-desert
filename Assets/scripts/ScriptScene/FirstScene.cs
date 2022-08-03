using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstScene : MonoBehaviour
{
	public  void LoadFirstLevel()
	{
		SceneManager.LoadScene(3);
	}


	public  void LoadNewsScene()
	{
		SceneManager.LoadScene(1);
	}


	public  void LoadSettings()
	{
		SceneManager.LoadScene(2);
	}

}
