using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAttak : MonoBehaviour
{

	public int damage;




	private void OnCollisionEnter2D(Collision2D col)
  	{
  		if (col.gameObject.CompareTag("Player"))
  		{
  			col.gameObject.GetComponent<Player>().TakeDamage(damage);
  		}
  	}
}
