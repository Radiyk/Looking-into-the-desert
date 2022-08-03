using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyTouch : MonoBehaviour
{
	


    

	private void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.transform.tag =="Player")
		{
			MoneyText.money += 1;
			PlayerPrefs.SetInt("Money", MoneyText.money);
            Destroy(gameObject);
		}
		
	}

}
