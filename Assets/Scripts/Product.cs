using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Product : MonoBehaviour
{
    public GameObject shop;
    public GameObject CoinsSystem;

    //������ � ��������
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
        //�������� ������ � �������� �� ID
        productName = shop.GetComponent<SeedShopMeneger>().productName[id];
        price = shop.GetComponent<SeedShopMeneger>().price[id];
        seed = shop.GetComponent<SeedShopMeneger>().seed[id];
        sell = shop.GetComponent<SeedShopMeneger>().sell[id];
        growPlant = shop.GetComponent<SeedShopMeneger>().growPlant[id];

        //���������� ��� � ���� � ��������
        nameText.text = productName.ToString();
        priceText.text = price.ToString();
    }

    //������� ������ � �������� (�������)
    public void Buy()
    {
        if (CoinsSystem.GetComponent<CoinsSystem>().coin >= price) //���� ������� ������
        {
            //�������� �� ������� ������
            if (this.GetComponent<Graphic>().color == Color.green) //���� ��� ������ ��� ������, �� �������� ������ ������� �����
            {
                        this.GetComponent<Graphic>().color = Color.white;
                        this.gameObject.tag = "Untagged";
                        CoinsSystem.GetComponentInChildren<CoinsSystem>().coin += price;          
            }
            else                                                    //���� ��� ������ �� ������, �� ������ ������ � ������ �����
            {
                        findOtherSell();
                        this.GetComponent<Graphic>().color = Color.green;
                        this.gameObject.tag = "sell";
                        CoinsSystem.GetComponentInChildren<CoinsSystem>().coin -= price;
            }
        }

    }
    private void findOtherSell() //���� �� ������ ������� ������
    {
        GameObject otherObject = GameObject.FindGameObjectWithTag("sell");
        if (otherObject != null) //���� ����� ������ ����, �� �������� �� � ������� �����
        {
            otherObject.GetComponent<Graphic>().color = Color.white;
            otherObject.gameObject.tag = "Untagged";
            CoinsSystem.GetComponentInChildren<CoinsSystem>().coin += otherObject.GetComponent<Product>().price;
        }
    }
}
