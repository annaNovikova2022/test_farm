using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed : MonoBehaviour
{
    public int id;

    public GameObject plantGrow;


    void Start()
    {
        id = Product.whichSeed;

        StartCoroutine(Wait());
    }

    void Update()
    {

    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5f);

        GameObject newPlant = Instantiate(plantGrow, transform.position, transform.rotation);
        newPlant.GetComponent<Plant>().id = id;
        Destroy(this.gameObject);
    }
}
