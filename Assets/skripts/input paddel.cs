using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class inputpaddel : MonoBehaviour
{
    // speed and type of peddle
    public float speed = 3.0f;
    public string leftOrRight;


    // Start is called before the first frame update
    // ket the paddle go up and down
    void setKeyAndMovement(KeyCode up, KeyCode down)
    {
        //go up
        if (Input.GetKey(up))
        {
            //speed up
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        // go down
        else if (Input.GetKey(down))
        {
            // speed down 
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // lest use W and S as play button
        if (leftOrRight == "left")
        {
            setKeyAndMovement(KeyCode.W, KeyCode.S);
        }
        // right use UpArrow and DownArrow as play buttons
        else if (leftOrRight == "right")
        {
            setKeyAndMovement(KeyCode.UpArrow, KeyCode.DownArrow);
        }
    }
}
       

