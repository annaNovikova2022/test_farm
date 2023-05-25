using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedShopMeneger : MonoBehaviour
{
    public GameObject ShopWindow;

    //Данные о растениях
    public int[] id;

    public string[] productName;
    public int[] price;
    public int[] sell;
    public int numberOfProduct;
    public GameObject[] products; //Кнопка в магазине
    public GameObject[] seed;     //Объект семечка
    public GameObject[] growPlant;//Объект выросшего растения
    
    void Start()
    {
        //Заполнение кнопок в магазине
        for (int i = 0; i < numberOfProduct; i++)
        {
            products[i].GetComponent<Product>().id = id[i];
            products[i].SetActive(true);
        }
    }
    void Update()
    {

    }

    //Открытие или закрытие магазина
    public void ShopMode()
    {
        if (ShopWindow.active == false)
        {
            ShopWindow.SetActive(true);
        }
        else ShopWindow.SetActive(false);

    }
}
