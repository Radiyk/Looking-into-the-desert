using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpen : MonoBehaviour
{
	private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

	// public void OpenChest()
	// {
	// 	Debug.Log("Yes");
	// 	anim.SetTrigger("PiperShow");
	// }

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			anim.SetTrigger("PiperShow");
		}
	}


}
