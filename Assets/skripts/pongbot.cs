using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pongbot : MonoBehaviour
{
    public float yspeed = 3f;
    public float yposition = 0f;
    public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yposition = yposition + yspeed * Time.deltaTime;
      transform.position.y =  new Vector3 (transform.position.x, yposition, yposition.);
        if (yposition >=3.6)
        {
            yspeed = yspeed * -1f;
        }
        else if (yposition <=-3.6f)
        {  yspeed = yspeed * -1f;
        }
        transform.position = new Vector3 (transform.position.x, ball.trn.y/ansitio)

    }
}
