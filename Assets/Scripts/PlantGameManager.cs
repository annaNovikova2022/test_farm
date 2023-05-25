using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantGameManager : MonoBehaviour
{
    public GameObject CoinsSystem;

    //Prefab для замены объекта
    public GameObject field;
    public GameObject plant; //Заполняется при нажатии на кнопку в магазине

    private GameObject hitted; //Объект, соприкасающийся с Raycast
    
    void Start()
    {

    }
    void Update()
    {
       
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;

            plant = GameObject.FindGameObjectWithTag("sell"); //Нажата ли кнопка в магазине

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit)) //Выпускаем луч
            {
                if (plant != null && hit.collider.CompareTag("Field")) //Если предмет в магазине выбран и обнаруженный объект не имеет растения, то садим растение
                {
                    hitted = hit.transform.gameObject;
                    GameObject newSeed = Instantiate(plant.GetComponent<Product>().seed, hitted.transform.position, Quaternion.identity); //Создание нового объекта

                    //Передаем новому объекту данные
                    newSeed.GetComponent<Seed>().id = plant.GetComponent<Product>().id;
                    newSeed.GetComponent<Seed>().sell = plant.GetComponent<Product>().sell;
                    newSeed.GetComponent<Seed>().plantGrow = plant.GetComponent<Product>().growPlant;

                    Destroy(hitted); //Удаление старого объекта

                    //Изменяем кнопку в магазине на неактивную
                    GameObject otherObject = GameObject.FindGameObjectWithTag("sell");
                    otherObject.GetComponent<Graphic>().color = Color.white;
                    otherObject.gameObject.tag = "Untagged";
                    

                }

                if (hit.collider.CompareTag("Grow up")) //Если обнаруженный объект имеет растение, которое уже вырасло, то собираем его и получаем капли
                {
                    hitted = hit.transform.gameObject;
                    Instantiate(field, hitted.transform.position, Quaternion.identity); //Объект без растения

                    CoinsSystem.GetComponentInChildren<CoinsSystem>().coin += hitted.GetComponent<Plant>().sell; //Добавляем капли к общему счету
                   
                    Destroy(hitted);   //Удаление старого объекта                  
                }
            }
                
        }
        
        
    }

   

}
