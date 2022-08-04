using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPressung : MonoBehaviour
{
    private Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.transform.tag =="Player")
		{
            anim.SetBool("isPressure", true);
		}
        
	}

    private void OnCollisionExit2D(Collision2D coll)
	{
		if (coll.transform.tag =="Player")
		{
            anim.SetBool("isPressure", false);
		}
        
	}
}
