using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMeneger : MonoBehaviour
{
    public GameObject ShopWindow;

    public int[] id;
    public string[] productName;
    public int[] price;

    public int numberOfProduct;

    public GameObject[] products;
    void Start()
    {
        for (int i = 0; i < numberOfProduct; i++)
        {
            products[i].SetActive(false);
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
            products[i].SetActive(false);
        }

        
        for (int i = 0; i < numberOfProduct; i++)
        {
           products[i].GetComponent<Plant>().id = id[i];
           products[i].SetActive(true);
        }
        
    }
}
