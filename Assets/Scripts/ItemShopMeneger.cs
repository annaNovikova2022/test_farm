using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemShopMeneger : MonoBehaviour
{
    public GameObject ShopWindow;

    public int[] id;
    public string[] itemName;
    public int[] price;
    public int numberOfProduct;

    public GameObject[] item;
    void Start()
    {
        for (int i = 0; i < numberOfProduct; i++)
        {
            item[i].SetActive(true);
        }

        Refresh();
    }

    
    void Update()
    {
        
    }

    public void ShopMode()
    {
        if(ShopWindow.active == false)
        {
            ShopWindow.SetActive(true);
        }
        else ShopWindow.SetActive(false);
        
    }


    public void Refresh()
    {

        for (int i = 0; i < numberOfProduct; i++)
        {
            item[i].GetComponent<Item>().id = id[i];
            item[i].SetActive(true);
        }
        
    }
}
