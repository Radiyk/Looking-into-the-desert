using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TwoScene : MonoBehaviour
{
	public  void LoadExet()
	{
		SceneManager.LoadScene(0);
	}
	public  void LoadFirstLevel()
	{
		SceneManager.LoadScene(4);
	}
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
