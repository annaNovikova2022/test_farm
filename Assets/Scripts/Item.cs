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

    public static bool placeSeeds;
    public static int whichSeed;



    
    void Start()
    {
        shop = GameObject.Find("ShopSeed");

        CoinsSystem = GameObject.Find("Coins System");
    }

    
    void Update()
    {
        nameText.text = "" + itemName;
        priceText.text = price + " $";

        itemName = shop.GetComponent<ItemShopMeneger>().itemName[id];
        price = shop.GetComponent<ItemShopMeneger>().price[id];
    }

    public void Buy()
    {
        
        if (CoinsSystem.GetComponent<CoinsSystem>().coin >= price)
        {
            if (this.GetComponent<Graphic>().color == Color.green)
                    {
                        placeSeeds = true;
                        whichSeed = id;
                        this.GetComponent<Graphic>().color = Color.white;
                        this.gameObject.tag = "Untagged";
                        CoinsSystem.GetComponentInChildren<CoinsSystem>().coin += price;

            }
            else
                    {
                        findOtherSell();
                        this.GetComponent<Graphic>().color = Color.green;
                        this.gameObject.tag = "sell";
                        CoinsSystem.GetComponentInChildren<CoinsSystem>().coin -= price;
            }
        }

    }
    private void findOtherSell()
    {
        GameObject otherObject = GameObject.FindGameObjectWithTag("sell");
        if (otherObject != null)
        {
            otherObject.GetComponent<Graphic>().color = Color.white;
            otherObject.gameObject.tag = "Untagged";
            CoinsSystem.GetComponentInChildren<CoinsSystem>().coin += otherObject.GetComponent<Product>().price;
        }
    }
}
