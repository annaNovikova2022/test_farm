using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsSystem : MonoBehaviour
{
    public int coin;
    public int coinMAX = 10;

    public Text coinText;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (coin > coinMAX) //Проверка лимита капель
        {
            coin = coinMAX;
        }
        coinText.text = coin + " \\ " +coinMAX;

    }
}
