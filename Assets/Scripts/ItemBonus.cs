using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBonus : MonoBehaviour
{
    public GameObject CoinsSystem;

    //Данные о предмете
    public int id;
    public int coinsTimeBonus; //Сколько монет дают за n времени

    public bool doTick = false;
    public float timer = 10f; //n-время до получения бонуса

    void Start()
    {
        CoinsSystem = GameObject.Find("Coins System");

        if (coinsTimeBonus != 0) //Если есть бонус на капли, то включить бонус
        {
            doTick = true;
            StartCoroutine(Ticker());
        }
        
    }
    void Update()
    {
        
    }

    //Бонус на количество монет
    IEnumerator Ticker()
    {
        while (doTick)
        {
            yield return new WaitForSeconds(timer);
            CoinsSystem.GetComponentInChildren<CoinsSystem>().coin += coinsTimeBonus;
        }
    }
}
