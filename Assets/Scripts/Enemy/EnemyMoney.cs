using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoney : MonoBehaviour
{
    private float lifetime = 10;


    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    
}
