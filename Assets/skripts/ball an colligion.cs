using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float Xposition = 0f;
    public float Yposition = 0f;
    public float xspeed;
    public float yspeed;
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(Xposition, Yposition, 0);
        xspeed = 1f;
        yspeed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        Xposition += xspeed * Time.deltaTime;
        Yposition += yspeed * Time.deltaTime;
        transform.position = new Vector3(Xposition, Yposition, 0);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("horizontalwall")) 
        {
            yspeed = yspeed * -1; 
        }

        else if (collision.gameObject.CompareTag("verticalwall"))
        {
            xspeed = xspeed * -1;       
        }

    }






}
    