using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCar : MonoBehaviour
{
    public float dikey_hız,yatay_hız, varsayılan_hız;
    private float dikey_hareket,yatay_hareket;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        dikey_hareket = Input.GetAxis("Vertical");
        yatay_hareket = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(yatay_hareket * 50 *yatay_hız *Time.deltaTime, varsayılan_hız + dikey_hareket * 50 * dikey_hız * Time.deltaTime);
        if (transform.position.x>1.85f)
        {
            Vector3 right_limit = new Vector3(1.85f, transform.position.y,0);
            transform.position = right_limit;
        }// SAĞ SATIR KONTROLÜ
        if (transform.position.x < -1.82f)
        {
            Vector3 left_limit = new Vector3(-1.82f, transform.position.y,0);
            transform.position = left_limit;
        } // SOL SATIR KONTROLÜ
    }
}
