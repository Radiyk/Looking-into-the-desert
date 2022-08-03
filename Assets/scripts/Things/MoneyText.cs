using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyText : MonoBehaviour
{
    public static int money;
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        if(PlayerPrefs.HasKey("Money"))
        {
            money = PlayerPrefs.GetInt("Money");
        }
    }

   
    void Update()
    {
        text.text = money.ToString();
    }
}
