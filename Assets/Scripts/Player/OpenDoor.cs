using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour
{

	private Animator anim;
	private AudioSource MyAudioSource;
	public  AudioClip[] AudioClips;
	private AudioClip BTN;
	private AudioClip speech;
	private AudioClip Perehod;
    void Start()
    {
		anim = GetComponent<Animator>();

		MyAudioSource = GetComponent<AudioSource>();
		BTN = MyAudioSource.clip=AudioClips[0];
		speech = MyAudioSource.clip=AudioClips[1];
		Perehod = MyAudioSource.clip=AudioClips[2];
    }

    

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			anim.SetTrigger("doorSpeech");
			MyAudioSource.PlayOneShot(speech);
			
		}
	}

	
	public void AnswerIsNo()
	{
		anim.SetTrigger("AnswerIsNo");
	}


	public void BtnOk()
	{
		MyAudioSource.PlayOneShot(BTN);
		MyAudioSource.PlayOneShot(Perehod);
		anim.SetTrigger("BtnOk");
	}


	public void LoScMini()
	{
		SceneManager.LoadScene(5);
	}
}
