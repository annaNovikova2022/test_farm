using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantGameManager : MonoBehaviour
{ 
    public GameObject field;
    private GameObject hitted;

    public GameObject plant;
   

    void Start()
    {
        
    }


    void Update()
    { 
        if (GameObject.FindGameObjectWithTag("sell") && Input.GetMouseButton(0))
        {
                RaycastHit hit;
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
                {
                    if (hit.collider.CompareTag("Field"))
                    {
                        hitted = hit.transform.gameObject;
                        Instantiate(field, hitted.transform.position, Quaternion.identity);
                        Destroy(hitted);
                    }
                }
        }
        
        
    }

    void planting()
    {
        this.transform.position = Vector3.zero;
        Vector3 vector3 = transform.position;
        Instantiate(plant, new Vector3(0, 0, 0), Quaternion.identity);
        plant.transform.position = this.transform.position;
    }

}
