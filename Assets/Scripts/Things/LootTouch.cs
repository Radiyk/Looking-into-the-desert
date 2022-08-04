using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootTouch : MonoBehaviour
{
	private Animator anim;

	private  AudioSource MyAudioSource;
	private  int healAmount = 1;


    void Start()
    {
		anim = GetComponent<Animator>();

		MyAudioSource = GetComponent<AudioSource>();
    }

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			MyAudioSource.Play();
			anim.SetTrigger("lootEffect");
			other.GetComponent<Player>().RestoreHealth(healAmount);
		}
	}

	public void TimeDead()
	{
		Destroy(gameObject);
	}
}
