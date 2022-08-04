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
    // Start is called before the first frame update
    void Start()
    {
		anim = GetComponent<Animator>();

		MyAudioSource = GetComponent<AudioSource>();
		BTN = MyAudioSource.clip=AudioClips[0];
		speech = MyAudioSource.clip=AudioClips[1];
		Perehod = MyAudioSource.clip=AudioClips[2];
    }

    

	private void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.CompareTag("Player"))
		{
			anim.SetTrigger("doorSpeech");
			MyAudioSource.PlayOneShot(speech);
		}
	}


	private void OnCollisionExit2D(Collision2D col)
	{
		if (col.gameObject.CompareTag("Player"))
		{
			AnswerIsNo();
		}
	}

	public void AnswerIsNo()
	{
		anim.SetBool("AnswerIsNo", true);
		Debug.Log("HH");
	}

	public void BackAnswerIsNo()
	{
		anim.SetBool("AnswerIsNo", false);
		Debug.Log("gg");
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
