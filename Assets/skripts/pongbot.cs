using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;



//public class Paddle_bot : MonoBehaviour
//{

//    public float speed = 3.0f;  // Adjust the speed as needed
//    public float minY = (float)-3.60;  // The lowest position
//    public float maxY = 3.60f;  // The highest position
//    private bool movingUp = true;

//    //Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (movingUp)
//        {
//            transform.Translate(Vector3.up * speed * Time.deltaTime);
//            if (transform.position.y >= maxY)
//            {
//                movingUp = false;
//            }
//        }
//        else
//        {
//            transform.Translate(Vector3.down * speed * Time.deltaTime);
//            if (transform.position.y <= minY)
//            {
//                movingUp = true;
//            }
//        }
//    }
//}





public class Paddle_bot : MonoBehaviour
{
    public float ySpeed = 4f;
    private float yPosition = 0f;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        yPosition = yPosition = ySpeed * Time.deltaTime;
        //transform.position.y = new Vector3(transform.position.x, yPosition, transform.position.z);
        //if (yPosition >= 3.6f)
        //{
        //    ySpeed = ySpeed * -1f;
        //}
        //else if (yPosition <= -3.6f)
        //{
        //    ySpeed = ySpeed * -1f;
        //}
        transform.position = new Vector3(transform.position.x, ball.transform.position.y / 1, transform.position.z);
    }
}



//public class Paddle_bot : MonoBehaviour
//{
//    public float ySpeed = 3f;
//    private float yPosition = 0;
//public float minY = (float)-7.60;  // The lowest position
//public float maxY = 7.60f;  // The highest position
//public GameObject ball;

//    //    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {

//     yPosition = yPosition + ySpeed * Time.deltaTime;
//     transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
//     if (yPosition >= 9.6f)
//     {
//        ySpeed = ySpeed * -1f;
//     }
//     else if (yPosition <= -9.6f)
//     {
//     ySpeed = ySpeed * -1f;
//     }
//     transform.position = new Vector3(transform.position.x, ball.transform.position.y / ySpeed, transform.position.z);
//    }
//}


