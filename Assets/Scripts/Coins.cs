using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public Text text;
    private int coins;

    void Start()
    {
        coins = 10;
        text.text = coins.ToString();
      
        // ���������� ��������� ������ �� �����������
        text.transform.SetParent(this.transform);

        // ���������� ���� ������
        text.color = Color.black;
 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
