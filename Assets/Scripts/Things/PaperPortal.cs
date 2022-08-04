using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperPortal : MonoBehaviour
{

	public Player player;


    void Start()
    {


    }

		void OnTriggerEnter2D(Collider2D other)
	    {
			if (other.CompareTag("Player"))
			{
				//player.GetComponent<AudioSource>().PlayOneShot(portal);
				player.GetComponent<Animator>().SetTrigger("inPortal");
			}
	    }


}
