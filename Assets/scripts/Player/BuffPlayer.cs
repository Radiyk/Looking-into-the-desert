using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffPlayer : MonoBehaviour
{
    
    
    [HideInInspector] public bool isShield;

    private Animator anim;


    void Start()
    {
       anim = GetComponent<Animator>();
       isShield = false; 
    }

    
    public void BluBuff()
    {
        StartCoroutine ("TimeShield");
    }

    IEnumerator TimeShield()
    {
            anim.SetBool("isBluBuff", true);
            isShield = true; 

            yield return new WaitForSeconds (5f);

            anim.SetBool("isBluBuff", false);
            isShield = false; 

    }
}
