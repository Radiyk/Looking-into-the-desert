using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmforDistroy : MonoBehaviour
{


	
	private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Grunt")
        {
            Destroy(gameObject);
        }
    }
}
