using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpirit : MonoBehaviour

{

		public int health;
		public float speed;
		public float positionOfPatrol;
		public Transform point;

		private bool isRightDirection;
		private  Rigidbody2D rb;
		private float stopTime;
		private float StartStopTime;
		private float normalSpeed;
		public GameObject money;


		Transform player;
		private float stoppingDistance =4;
		bool chill = false;
		bool angry = false;
		bool goBack = false;

		public Transform attackPos;
		public float distanceAttack;




		private void Start()
		{
			player = GameObject.FindGameObjectWithTag("Player").transform;
			normalSpeed = speed;
			rb = GetComponent<Rigidbody2D>();
			
		}

		private void FixedUpdate()
		{
			if (stopTime <= 0)
			{
				speed = normalSpeed;
			}
			else
			{
				speed = 0;
				stopTime -= Time.deltaTime;
			}
			if (health <=0)
			{
				Instantiate(money, transform.position, transform.rotation);
				Destroy(gameObject);
			}

		}

		public void TakeDamage(int damage)
		{
			stopTime = StartStopTime;
			health -= damage;
		}

		void Flip()
		{
			transform.Rotate(0f, -180f, 0f);
		}

		private void Update()
	    {


			if (Vector2.Distance(transform.position, point.position) < positionOfPatrol && angry == false)
			{
				chill = true;
			}
			if (Vector2.Distance(transform.position, player.position) < stoppingDistance)
			{
				angry = true;
				chill = false;
				goBack = false;
			}
			if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
			{
				goBack = true;
				angry = false;
			}
			if (chill == true)
			{
				Chill();
			}
			else if (angry == true)
			{
				Angry();
			}
			else if (goBack == true)
			{
				GoBack();
			}

	    }

		void Chill()
		{
			if (isRightDirection)
			{
				rb.velocity = Vector2.left * speed;
				if (transform.position.x < point.transform.position.x - positionOfPatrol)
				{
					isRightDirection = false;
					Flip();

				}

			}
			else
			{
				rb.velocity = Vector2.right * speed;
				if (transform.position.x > point.transform.position.x + positionOfPatrol)
				{
					isRightDirection = true;
					Flip();

				}
			}
		}



		void Angry()
		{
			transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
		}

		void GoBack()
		{
			transform.position = Vector2.MoveTowards(transform.position, point.position, speed * Time.deltaTime);
		}



	   private void OnDrawGizmosSelected()
	   {
		   Gizmos.color = Color.red;
		   Gizmos.DrawWireSphere(attackPos.position, distanceAttack);
	   }

	}
