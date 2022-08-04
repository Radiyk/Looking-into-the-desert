using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool isPause = false;

    // Update is called once per frame
    void Update()
    {

    }

	public void PauseEvent()
	{
		if(isPause == false)
		{
			Time.timeScale = 0f;
			isPause = true;
		}
		else
		{
			Time.timeScale = 1f;
			isPause = false;
		}
	}


	public void InMainMenu()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(0);
		isPause = false;
	}
}
