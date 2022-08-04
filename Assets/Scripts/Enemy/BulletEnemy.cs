using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
	private float speed = 5f;
	private Rigidbody2D rb;
	private float lifetime = 2;
  private int damage = 1;


    void Start()
    {
		rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;

		Destroy(gameObject, lifetime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
      if (other.CompareTag("Player"))
      {
        other.GetComponent<Player>().TakeDamage(damage);
      }
    } 
}
