using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
	public GameObject   bullet;
	public Transform shotPoint;
	//private Animator anim;
	private float timeBtwShots;
	public float startTimeBtwShots;


	//private  AudioSource MyAudioSource;
	//public  AudioClip[] AudioClips;
	//private AudioClip shoot;


	private void Start()
	{
		
		//anim = GetComponent<Animator>();
		//MyAudioSource = GetComponent<AudioSource>();
		//shoot = MyAudioSource.clip=AudioClips[0];
	}


	void Update()
	{

		if (timeBtwShots <= 0)
		{
			//anim.SetTrigger("isShot");
			//MyAudioSource.PlayOneShot(shoot);
			Instantiate(bullet, shotPoint.position, shotPoint.rotation);
			timeBtwShots = startTimeBtwShots;
		}
		else
		{
			timeBtwShots-= Time.deltaTime;
		}
	}


}
