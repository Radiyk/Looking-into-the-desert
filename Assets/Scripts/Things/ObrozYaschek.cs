using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObrozYaschek : MonoBehaviour
{
    public GameObject prompt;
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
      if (other.CompareTag("Player"))
      {
        prompt.SetActive(true);
      }
    } 

    private void OnTriggerExit2D(Collider2D other)
    {
      if (other.CompareTag("Player"))
      {
        prompt.SetActive(false);
      }
    } 
}
