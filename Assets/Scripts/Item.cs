using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public GameObject shop;

    public GameObject CoinsSystem;


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

        itemName = shop.GetComponent<ItemShopMeneger>().itemName[id];
        price = shop.GetComponent<ItemShopMeneger>().price[id];
    }

    public void Buy()
    {
        
        if (CoinsSystem.GetComponent<CoinsSystem>().coin >= price)
        {
            this.GetComponent<Graphic>().color = Color.gray;
            shop.GetComponent<ItemShopMeneger>().objects[id].SetActive(true);
            shop.GetComponent<ItemShopMeneger>().objects[id].GetComponent<ItemBonus>().doTick = true;
            CoinsSystem.GetComponentInChildren<CoinsSystem>().coin -= price;
            CoinsSystem.GetComponent<CoinsSystem>().coinMAX += shop.GetComponent<ItemShopMeneger>().increase[id];
        }

    }

}
