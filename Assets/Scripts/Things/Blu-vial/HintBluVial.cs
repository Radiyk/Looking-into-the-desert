using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintBluVial : MonoBehaviour
{

    public GameObject hint;
    

    void Start()
    {
        hint.SetActive(false);
    }

    
    public void ActiveHint()
    {
        hint.SetActive(true);
        StartCoroutine ("Destroyed");
    }

    IEnumerator Destroyed()
    {
        yield return new WaitForSeconds (6f);
        Destroy(gameObject);
    }
}
