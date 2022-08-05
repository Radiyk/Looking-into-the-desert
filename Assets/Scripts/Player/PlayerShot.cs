using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{

	public   GameObject bullet;
	public Transform shotPoint;
	private Animator anim;
	private float timeBtwShots;
	public float startTimeBtwShots;

	private bool este;

	private  AudioSource MyAudioSource;
	public  AudioClip[] AudioClips;
	private AudioClip shoot;


	private void Start()
	{
		anim = GetComponent<Animator>();
		MyAudioSource = GetComponent<AudioSource>();
		shoot = MyAudioSource.clip=AudioClips[0];
	}


    void Update()
    {

		if (timeBtwShots <= 0)
		{

			este = true;
		}
		else
		{
			este = false;
			timeBtwShots-= Time.deltaTime;
		}
    }

	public void playShot()
	{


		if (este)
		{
			MyAudioSource.PlayOneShot(shoot);
			Instantiate(bullet, shotPoint.position, shotPoint.rotation);
			timeBtwShots = startTimeBtwShots;
		}

	}
	public void shot()
	{
		anim.SetTrigger("isAttack");
	}



}
