using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{

    private Transform position;

    public float x, y, z;


    void Start()
    {
        position = GetComponent<Transform>();
        Load();
    }

   

    void Update()
    {
        x = position.transform.position.x;
        y = position.transform.position.y;
        z = position.transform.position.z;
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("X", x);
        PlayerPrefs.SetFloat("Y", y);
        PlayerPrefs.SetFloat("Z", z);
    }

    private void Load()
    {
        if (PlayerPrefs.HasKey("X"))
        {
            x = PlayerPrefs.GetFloat("X");
        }
        if (PlayerPrefs.HasKey("Y"))
        {
            y = PlayerPrefs.GetFloat("Y");
        }
        if (PlayerPrefs.HasKey("Z"))
        {
            z = PlayerPrefs.GetFloat("Z");
        }

        position.transform.position = new Vector3(x, y, z);
    }
}
