using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public GameObject shop;
    public GameObject CoinsSystem;

    //Данные о предмете
    public int id;
    public string itemName;
    public int price;

    public Text nameText, priceText;
    
    void Start()
    {
        shop = GameObject.Find("ShopItem");
        CoinsSystem = GameObject.Find("Coins System");
    }

    
    void Update()
    {
        nameText.text = itemName.ToString();
        priceText.text = price.ToString();

        //По ID ищем данные о предмете
        itemName = shop.GetComponent<ItemShopMeneger>().itemName[id];
        price = shop.GetComponent<ItemShopMeneger>().price[id];
    }

    //Нажатие кнопки в магазине (Покупка)
    public void Buy()
    {
        
        if (CoinsSystem.GetComponent<CoinsSystem>().coin >= price) //Хватает ли капель
        {
            this.GetComponent<Graphic>().color = Color.gray;

            shop.GetComponent<ItemShopMeneger>().objects[id].SetActive(true); //Объект становится видимым

            //Отнимаем стоимость предмета и увеличение максимального запаса капель
            CoinsSystem.GetComponentInChildren<CoinsSystem>().coin -= price;
            CoinsSystem.GetComponent<CoinsSystem>().coinMAX += shop.GetComponent<ItemShopMeneger>().increase[id];
        }

    }

}
