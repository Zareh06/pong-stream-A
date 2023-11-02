using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.UIElements;

public class ballAndColligion : MonoBehaviour
{
    // setting for the ball
    // move in x and y diractions
    // change course when it collide wiht a wall or a paddle
    // showing the scoreing board 
    public float Xposition = 0f;
    public float Yposition = 0f;
    public float xspeed ;
    public float yspeed ;
    public TMP_Text scoreField; // refresne (has to be linked with unety)
    private int Leftscore = 0;
    private int Rightscore = 0;
    public int Topscore = 10;

   // reset ball to start and let go ;eft or right
    private void resetBall(string leftOrRight)
    {
        Xposition = 0f; // if you score than the ball rest too this position
        Yposition = 0f; // if you score than the ball rest too this position
        scoreField.text = Leftscore + " - " + Rightscore; // if you score than the score board went up by 1
        if (leftOrRight == "left")// check argument from the functions if left or richt is typed
        {// ball goes right and up
            xspeed = 2f;
            yspeed = 2f; 

        }
        else if (leftOrRight == "right")
        {
            xspeed = -2f;
            yspeed = 2f; // if right score that the bal is going right
        }
    }
    void Start()
    {
        transform.position = new Vector3(Xposition, Yposition, 0); // when you start the game the ball resret to position 0
    }
    // Update is called once per frame
    void Update()
    {
        // updates the posistion and speed of the X and Y  delta time does ball not moving on frame rate but on actual time so speed is the same al the time
        Xposition += xspeed * Time.deltaTime;
        Yposition += yspeed * Time.deltaTime;
        transform.position = new Vector3(Xposition, Yposition, 0);
        //check if left or right score is ecual or bigger than top score
        // if its met it stop the ball and place the ball in the middle
        // show in text field witch player won
        if (Leftscore >= Topscore)
        {
            scoreField.text = "Right Player Has Won!";
            xspeed = 0;
            yspeed = 0;
            Xposition = 0f;
            Yposition = 0f;
        }
        else if (Rightscore >= Topscore)
        {
            scoreField.text = "Left Player Has Won!";
            xspeed = 0;
            yspeed = 0;
            Xposition = 0f;
            Yposition = 0f;
        }
    }
    // if it hits somethinge a game object with a collider  and that on is set to a trigger it does sometihing
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if game object has a tag that is called horzontalwall
        // and it has a collider on it set to trigger  
        if (collision.gameObject.CompareTag("horizontalwall")) 
        {
            // change directions vertical
            yspeed = yspeed * -1f; 
        }
        else if (collision.gameObject.CompareTag("verticalwall"))
        {
            yspeed = yspeed * -1f;
        }
        // adds +1 to the score board if it hits the leftwall and it reset tho the right
        else if (collision.gameObject.CompareTag("leftwall"))
        {
            xspeed = xspeed * -1f;
            Rightscore++;
            scoreField.text = Leftscore + " - " + Rightscore;
            resetBall("left");
        }
        // same thing as above but thent you hit the rightwal
        else if (collision.gameObject.CompareTag("rightwall"))
        {
            xspeed = xspeed * -1f;
            Leftscore++;
            scoreField.text = Leftscore + " - " + Rightscore;
            resetBall("right");
        }

        else if (collision.gameObject.CompareTag("Player"))
        {
            // if it hits the paddle it flips the horizontal direction and increase the speed with 10%
            xspeed = xspeed * -1.1f;
        }
    }






}
    