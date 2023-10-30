using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class inputpaddel : MonoBehaviour
{
    public float speed = 3.0f;
    public string leftOrRight;


    // Start is called before the first frame update
    void setKeyAndMovement(KeyCode up, KeyCode down)
    {
        if (Input.GetKey(up))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(down))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (leftOrRight == "left")
        {
            setKeyAndMovement(KeyCode.W, KeyCode.S);
        }
        else if (leftOrRight == "right")
        {
            setKeyAndMovement(KeyCode.UpArrow, KeyCode.DownArrow);
        }
    }
}
       
        //if (leftOrRight == "Left")    
        //{
        //    if (Input.GetKey(KeyCode.W))
        //    {
        //        transform.Translate(Vector3.up * speed * Time.deltaTime);
        //        Debug.Log("Yes W is pressed down");
        //    }
        //    else if (Input.GetKey(KeyCode.S))
        //    {
        //        transform.Translate(Vector3.down * speed * Time.deltaTime);
        //        Debug.Log("Yes S is pressed down");
        //    }
        //} 
        //if (leftOrRight == "Right") 
        //{
        //    if (Input.GetKey(KeyCode.UpArrow))
        //    {
        //        transform.Translate(Vector3.up * speed * Time.deltaTime);
        //        Debug.Log("Yes W is pressed down");
        //    }
        //    else if (Input.GetKey(KeyCode.DownArrow))
        //    {
        //        transform.Translate(Vector3.down * speed * Time.deltaTime);
        //        Debug.Log("Yes down arrow is pressed down");
        //    }
        //}
      
    //}
//}
