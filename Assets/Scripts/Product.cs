using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Product : MonoBehaviour
{
    public GameObject shop;
    public GameObject CoinsSystem;

    //Данные о растении
    public int id;

    public string productName;
    public int price;
    public int sell;
    public GameObject seed;
    public GameObject growPlant;

    public Text nameText, priceText;

    void Start()
    {
        shop = GameObject.Find("ShopSeed");
        CoinsSystem = GameObject.Find("Coins System");
    }

    void Update()
    {
        //Получаем данные о продукте по ID
        productName = shop.GetComponent<SeedShopMeneger>().productName[id];
        price = shop.GetComponent<SeedShopMeneger>().price[id];
        seed = shop.GetComponent<SeedShopMeneger>().seed[id];
        sell = shop.GetComponent<SeedShopMeneger>().sell[id];
        growPlant = shop.GetComponent<SeedShopMeneger>().growPlant[id];

        //Отображаем имя и цену в магазине
        nameText.text = productName.ToString();
        priceText.text = price.ToString();
    }

    //Нажатие кнопки в магазине (Покупка)
    public void Buy()
    {
        if (CoinsSystem.GetComponent<CoinsSystem>().coin >= price) //Если хватает капель
        {
            //Проверка на нажатие кнопки
            if (this.GetComponent<Graphic>().color == Color.green) //Если эта кнопка уже нажата, то сбросить кнопку вернуть капли
            {
                        this.GetComponent<Graphic>().color = Color.white;
                        this.gameObject.tag = "Untagged";
                        CoinsSystem.GetComponentInChildren<CoinsSystem>().coin += price;          
            }
            else                                                    //Если эта кнопка не нажата, то нажать кнопку и отнять капли
            {
                        findOtherSell();
                        this.GetComponent<Graphic>().color = Color.green;
                        this.gameObject.tag = "sell";
                        CoinsSystem.GetComponentInChildren<CoinsSystem>().coin -= price;
            }
        }

    }
    private void findOtherSell() //Есть ли другая нажатая кнопка
    {
        GameObject otherObject = GameObject.FindGameObjectWithTag("sell");
        if (otherObject != null) //Если такая кнопка есть, то сбросить ее и вернуть капли
        {
            otherObject.GetComponent<Graphic>().color = Color.white;
            otherObject.gameObject.tag = "Untagged";
            CoinsSystem.GetComponentInChildren<CoinsSystem>().coin += otherObject.GetComponent<Product>().price;
        }
    }
}
