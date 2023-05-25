using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBonus : MonoBehaviour
{
    public int id;
    public int coinsTime;
    public bool doTick = false;
    public float waitTime = 10f;

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
            yield return new WaitForSeconds(waitTime);
            CoinsSystem.GetComponentInChildren<CoinsSystem>().coin += coinsTime;
        }
    }
}
