using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Product : MonoBehaviour
{
    public GameObject shop;

    public GameObject CoinsSystem;

    public int id;
    public string productName;
    public int price;

    public Text nameText, priceText;

    public static bool placeSeeds;
    public static int whichSeed;

    public static bool isShowing;

    public static int currentProduct;

    
    void Start()
    {
        shop = GameObject.Find("Shop");

        CoinsSystem = GameObject.Find("Coins System");
    }

    
    void Update()
    {
        nameText.text = "" + productName;
        priceText.text = price + " $";

        productName = shop.GetComponent<ShopMeneger>().productName[id];
        price = shop.GetComponent<ShopMeneger>().price[id];
    }

    public void Buy()
    {
        
        if (CoinsSystem.GetComponent<CoinsSystem>().coin >= price)
        {
            if (this.GetComponent<Graphic>().color == Color.green)
                    {
                        this.GetComponent<Graphic>().color = Color.white;
                        this.gameObject.tag = "Untagged";

                    }
            else
                    {

                        this.GetComponent<Graphic>().color = Color.green;
                        this.gameObject.tag = "sell";
                    }
            /*placeSeeds = true;
            whichSeed = id;
            CoinsSystem.GetComponentInChildren<CoinsSystem>().coin -= price;

            currentProduct = price;

            isShowing = true;*/
        }

    }
}
