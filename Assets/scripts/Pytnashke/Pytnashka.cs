using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

                                          //IPointerClickHandler
public class Pytnashka : MonoBehaviour

{
    //public GameObject Objcol;
	public GameObject manager;
	public int number;
	public int numberCell;
	private BoxCollider2D col;
	public float distance;
	public float sise;

	private Bounds bounds;

	public GameObject Object;
	private Rigidbody2D rb;

    void Start()
    {
         col = Object.GetComponent<BoxCollider2D>();
		 Debug.Log(bounds);
		manager = GameObject.FindGameObjectWithTag("Canvas");
    }

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawLine(transform.position, transform.position + Vector3.right * transform.localScale.x * distance);
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Tregger"))
		{
			Debug.Log("Tregger");
			numberCell = other.transform.GetComponent<NumberCell>().numberCell;
			manager.GetComponent<Manager>().win();
		}
	}
	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.CompareTag("Tregger"))
		{
			Debug.Log("Tregger");
			numberCell = 0;
			manager.GetComponent<Manager>().win();
		}
	}

    public void vvvvv()
    {
		col.enabled = false;



		RaycastHit2D hitright = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, distance);
		if(hitright.collider == null)
		{
			transform.position = new Vector3(transform.position.x +sise, transform.position.y, transform.position.z);
		}

		else if(hitright.collider != null)
	   {
		   RaycastHit2D hitleft = Physics2D.Raycast(transform.position, Vector2.left * transform.localScale.x, distance);
   		if(hitleft.collider == null)
   		{
   			transform.position = new Vector3(transform.position.x -sise, transform.position.y, transform.position.z);
   		}
		else if(hitleft.collider != null)
		{
			RaycastHit2D hitup = Physics2D.Raycast(transform.position, Vector2.up * transform.localScale.x, distance);
			if(hitup.collider == null)
			{
				transform.position = new Vector3(transform.position.x, transform.position.y +sise, transform.position.z);
			}
			else
			{
				RaycastHit2D hitdown = Physics2D.Raycast(transform.position, Vector2.down * transform.localScale.x, distance);
				if(hitdown.collider == null)
				{
					transform.position = new Vector3(transform.position.x, transform.position.y -sise, transform.position.z);
				}
			}
		}

	   }


	   col.enabled = true;
    }
}
