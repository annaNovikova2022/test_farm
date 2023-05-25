using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemShopMeneger : MonoBehaviour
{
    public GameObject ShopWindow;

    public int[] id;
    public string[] itemName;
    public int[] price;
    public int[] increase;
    public int[] coinsTime;
    public int numberOfItem;

    public GameObject[] item;
    public GameObject[] objects;
    void Start()
    {
        for (int i = 0; i < numberOfItem; i++)
        {
            item[i].GetComponent<Item>().id = id[i];
            objects[i].GetComponent<ItemBonus>().coinsTime = coinsTime[i];
            item[i].SetActive(true);
        }
    }


    void Update()
    {

    }

    public void ShopMode()
    {
        if (ShopWindow.active == false)
        {
            ShopWindow.SetActive(true);
        }
        else ShopWindow.SetActive(false);

    }
}

