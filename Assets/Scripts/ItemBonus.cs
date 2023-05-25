using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBonus : MonoBehaviour
{
    public int id;
    public int coinsTime;
    public bool doTick = false;

    public GameObject CoinsSystem;

    void Start()
    {
        CoinsSystem = GameObject.Find("Coins System");

        StartCoroutine(Ticker());
    }

    
    void Update()
    {
        
    }

    IEnumerator Ticker()
    {
        while (doTick)
        {
            yield return new WaitForSeconds(3f);
            CoinsSystem.GetComponentInChildren<CoinsSystem>().coin += coinsTime;
        }
    }
}
