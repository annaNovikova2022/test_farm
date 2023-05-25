using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBonus : MonoBehaviour
{
    public GameObject CoinsSystem;

    //������ � ��������
    public int id;
    public int coinsTimeBonus; //������� ����� ���� �� n �������

    public bool doTick = false;
    public float timer = 10f; //n-����� �� ��������� ������

    void Start()
    {
        CoinsSystem = GameObject.Find("Coins System");

        if (coinsTimeBonus != 0) //���� ���� ����� �� �����, �� �������� �����
        {
            doTick = true;
            StartCoroutine(Ticker());
        }
        
    }
    void Update()
    {
        
    }

    //����� �� ���������� �����
    IEnumerator Ticker()
    {
        while (doTick)
        {
            yield return new WaitForSeconds(timer);
            CoinsSystem.GetComponentInChildren<CoinsSystem>().coin += coinsTimeBonus;
        }
    }
}
