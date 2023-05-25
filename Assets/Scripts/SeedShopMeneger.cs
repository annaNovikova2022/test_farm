using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedShopMeneger : MonoBehaviour
{
    public GameObject ShopWindow;

    public int[] id;
    public string[] productName;
    public int[] price;
    public int[] sell;
    public int numberOfProduct;

    public GameObject[] products;
    public GameObject[] seed;
    public GameObject[] growPlant;
    void Start()
    {
        for (int i = 0; i < numberOfProduct; i++)
        {
            products[i].GetComponent<Product>().id = id[i];
            products[i].SetActive(true);
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
