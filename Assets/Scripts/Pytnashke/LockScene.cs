using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LockScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

	public  void PredLostScene()
	{
		SceneManager.LoadScene(6);
	}


	public  void Exit()
	{
		SceneManager.LoadScene(4);
	}
}
