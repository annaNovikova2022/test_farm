using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantGameManager : MonoBehaviour
{
    public GameObject CoinsSystem;

    //Prefab ��� ������ �������
    public GameObject field;
    public GameObject plant; //����������� ��� ������� �� ������ � ��������

    private GameObject hitted; //������, ��������������� � Raycast
    
    void Start()
    {

    }
    void Update()
    {
       
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;

            plant = GameObject.FindGameObjectWithTag("sell"); //������ �� ������ � ��������

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit)) //��������� ���
            {
                if (plant != null && hit.collider.CompareTag("Field")) //���� ������� � �������� ������ � ������������ ������ �� ����� ��������, �� ����� ��������
                {
                    hitted = hit.transform.gameObject;
                    GameObject newSeed = Instantiate(plant.GetComponent<Product>().seed, hitted.transform.position, Quaternion.identity); //�������� ������ �������

                    //�������� ������ ������� ������
                    newSeed.GetComponent<Seed>().id = plant.GetComponent<Product>().id;
                    newSeed.GetComponent<Seed>().sell = plant.GetComponent<Product>().sell;
                    newSeed.GetComponent<Seed>().plantGrow = plant.GetComponent<Product>().growPlant;

                    Destroy(hitted); //�������� ������� �������

                    //�������� ������ � �������� �� ����������
                    GameObject otherObject = GameObject.FindGameObjectWithTag("sell");
                    otherObject.GetComponent<Graphic>().color = Color.white;
                    otherObject.gameObject.tag = "Untagged";
                    

                }

                if (hit.collider.CompareTag("Grow up")) //���� ������������ ������ ����� ��������, ������� ��� �������, �� �������� ��� � �������� �����
                {
                    hitted = hit.transform.gameObject;
                    Instantiate(field, hitted.transform.position, Quaternion.identity); //������ ��� ��������

                    CoinsSystem.GetComponentInChildren<CoinsSystem>().coin += hitted.GetComponent<Plant>().sell; //��������� ����� � ������ �����
                   
                    Destroy(hitted);   //�������� ������� �������                  
                }
            }
                
        }
        
        
    }

   

}
