using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed : MonoBehaviour
{
    //Данные о растении
    public int id;
    public int sell;
    public GameObject plantGrow; //Объек растения, которое выросло

    public float timer = 2f;

    void Start()
    {
        StartCoroutine(Wait()); //При появлении на сцене начинается отчет для роста
    }

    void Update()
    {

    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(timer);

        GameObject newPlant = Instantiate(plantGrow, transform.position, transform.rotation);

        //Передача данных новому объекту
        newPlant.GetComponent<Plant>().id = id;
        newPlant.GetComponent<Plant>().sell = sell;
        
        Destroy(this.gameObject);
    }
}
