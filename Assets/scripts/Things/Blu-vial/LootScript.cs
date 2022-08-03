using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootScript : MonoBehaviour
{
	private Animator anim;
	private  AudioSource MyAudioSource;
	public Item item;


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
			anim.SetTrigger("LootTach");
			Inventory.instance.PutInEmptySlot(item);
			
		}
	}

	public void TimeDead()
	{
		Destroy(gameObject);
	}

}
