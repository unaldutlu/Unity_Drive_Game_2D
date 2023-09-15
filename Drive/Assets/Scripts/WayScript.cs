using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayScript : MonoBehaviour
{
    public GameObject way;
    bool yol_yapıldı= false;


    void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.gameObject.tag == "mainCar" && yol_yapıldı== false)
        {
            Vector3 spawn_location = new Vector3(transform.position.x, transform.position.y + 10,0);
            Instantiate(way, spawn_location, Quaternion.identity);
            yol_yapıldı = true;
            Destroy(this.gameObject,10f);
        }
        
    }
}
