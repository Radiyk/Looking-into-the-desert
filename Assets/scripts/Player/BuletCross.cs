using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuletCross : MonoBehaviour
{
		public float speed;
		public float distance;
		public int damage;
		public LayerMask whatIsSolid;
		public float lifetime;
		public GameObject krashBarrel;
		public GameObject player;
		private Rigidbody2D rb;



	private void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		Destroy(gameObject, lifetime);
			rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
	}


	private void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.transform.tag =="Barrel")
		{
			coll.gameObject.GetComponent<DestroyBarrel>().DestroyGO();
			player.GetComponent<Player>().BarreiMusic();

			foreach (ContactPoint2D missileHit in coll.contacts)
			{
				Vector2 hitPoint = missileHit.point;
				Instantiate(krashBarrel, new Vector3(hitPoint.x, hitPoint.y, -1), Quaternion.identity);
			}

		}
		else if (coll.transform.tag =="Enemy")
		{
			coll.gameObject.GetComponent<EnemySpirit>().TakeDamage(damage);
			Destroy(gameObject);
		}
	}

}
