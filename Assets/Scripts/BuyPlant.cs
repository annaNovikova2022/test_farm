using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyPlant : MonoBehaviour
{
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Text coins;
    public int price;
    public GameObject plant;

    public void moveSell()
    {
        
        if (this.GetComponent<Graphic>().color == Color.green)
        {
            ChangeCoins(price);
            Cursor.SetCursor(null, Vector2.zero, cursorMode); // сброс курсора
            this.GetComponent<Graphic>().color = Color.white;
            this.gameObject.tag = "Untagged";

        }
        else
        {
            ChangeCoins(-price);
            findOtherSell();
            Cursor.SetCursor(cursorTexture, Vector2.zero, cursorMode);
            this.GetComponent<Graphic>().color = Color.green;
            this.gameObject.tag = "sell";
        }

    }

    private void findOtherSell()
    {
        GameObject otherObject = GameObject.FindGameObjectWithTag("sell");
        if (otherObject != null)
        {
            otherObject.GetComponent<Graphic>().color = Color.white;
            otherObject.gameObject.tag = "Untagged";
        }
    }
    private void ChangeCoins(int pris) 
    {
        int coin = int.Parse(coins.text);
        coin += pris;
        coins.text = coin.ToString();
    }

}
