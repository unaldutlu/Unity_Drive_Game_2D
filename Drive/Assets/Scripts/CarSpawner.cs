using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject random_car_npc;
    bool can_spawn = true;


    void Start()
    {
        StartCoroutine(bekle());
    }

    
    IEnumerator bekle()
    {
        while (can_spawn==true)
        {
            Instantiate(random_car_npc, transform.position,Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }
}
