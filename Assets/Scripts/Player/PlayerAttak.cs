using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttak : MonoBehaviour

{
    public Transform attackPos;
    public LayerMask enemy;
    public float distance;
    public int damage;
    public Animator anim;


    private void Update()
    {
		if (Input.GetKeyDown(KeyCode.R))
		{
			anim.SetTrigger("atack");

		}
    }

	private void OnAttack()
	{
		Collider2D[] enemies = Physics2D.OverlapCircleAll(attackPos.position, distance, enemy);

		for (int i = 0;i < enemies.Length; i++)
		{
			//enemies[i].GetComponent<Enemy>().TakeDamage(damage);
		}


	}
	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere(attackPos.position, distance);
	}
}
