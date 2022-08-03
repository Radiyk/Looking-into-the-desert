using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{

	public GameObject[] bjects;
	public GameObject victory;
	public bool isWin;

	private Animator anim;

	private void Start()
	{
		victory.SetActive(false);

		bjects = GameObject.FindGameObjectsWithTag("Cube");

		anim = GetComponent<Animator>();
	}


    public void win()
    {
        for (int i = 0; i < bjects.Length; i++)
		{
			if (bjects[i].GetComponent<Pytnashka>().number != bjects[i].GetComponent<Pytnashka>().numberCell)
			return;
		}
		Debug.Log("Win");
		isWin = true;
		victory.SetActive(true);
		Wiktory();
    }

    public void Wiktory()
	{



		anim.SetTrigger("victory");
	}



}
