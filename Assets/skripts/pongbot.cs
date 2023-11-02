using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;


public class Paddle_bot : MonoBehaviour
{
    // posistion and speed 
    public float ySpeed = 4f;
    private float yPosition = 0f;
    // it identify game object ball
    public GameObject ball;


    // Update is called once per frame
    void Update()
    {
        // this set the bot position and speed from the right paddle so that it won't take differnd speeds
        yPosition = yPosition = ySpeed * Time.deltaTime;
        //it follows the ball on the Y posistion
        transform.position = new Vector3(transform.position.x, ball.transform.position.y / 1, transform.position.z);
    }
}

