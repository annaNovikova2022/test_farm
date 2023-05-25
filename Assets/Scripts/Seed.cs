using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed : MonoBehaviour
{
    //������ � ��������
    public int id;
    public int sell;
    public GameObject plantGrow; //����� ��������, ������� �������

    public float timer = 2f;

    void Start()
    {
        StartCoroutine(Wait()); //��� ��������� �� ����� ���������� ����� ��� �����
    }

    void Update()
    {

    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(timer);

        GameObject newPlant = Instantiate(plantGrow, transform.position, transform.rotation);

        //�������� ������ ������ �������
        newPlant.GetComponent<Plant>().id = id;
        newPlant.GetComponent<Plant>().sell = sell;
        
        Destroy(this.gameObject);
    }
}
