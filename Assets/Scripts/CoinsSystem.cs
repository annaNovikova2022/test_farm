using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsSystem : MonoBehaviour
{
    public int coin;
    public int coinMAX = 10;



    public Text coinText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (coin > coinMAX)
        {
            coin = coinMAX;
        }
        coinText.text = coin + " \\ " +coinMAX;

    }
}
