using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amfora : MonoBehaviour
{
	private  AudioSource MyAudioSource;
	public GameObject krashAmfora;
	public bool isKrashAmfora;


	private void Start()
	{
		isKrashAmfora = false;
		MyAudioSource = GetComponent<AudioSource>();
	}



	private void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.transform.tag =="Amfora")
		{
			if (isKrashAmfora == false)
			{

				MyAudioSource.Play();


				foreach (ContactPoint2D missileHit in coll.contacts)
				{
					Vector2 hitPoint = missileHit.point;
					Instantiate(krashAmfora, new Vector3(hitPoint.x, hitPoint.y, -1), Quaternion.identity);

				}
				isKrashAmfora = true;
			}

		}
	}



}
