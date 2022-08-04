using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallInBottom : MonoBehaviour
{
	private Animator anim;



	private  AudioSource MyAudioSource;
	public  AudioClip[] AudioClips;
	private AudioClip fall;

    // Start is called before the first frame update
    void Start()
    {
		MyAudioSource = GetComponent<AudioSource>();
		fall = MyAudioSource.clip=AudioClips[0];
        anim = GetComponent<Animator>();
    }

	//падение в яму

	private void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.CompareTag("SpaceDead"))
		{
			// Debug.Log("SpaceDead");
			MyAudioSource.PlayOneShot(fall);
			anim.Play("Tim-aute-Fall");
		}
	}
}
