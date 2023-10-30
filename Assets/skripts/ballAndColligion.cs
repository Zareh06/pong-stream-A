using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.UIElements;

public class ballAndColligion : MonoBehaviour
{
    public float Xposition = 0f;
    public float Yposition = 0f;
    public float xspeed ;
    public float yspeed ;
    public TMP_Text scoreField;
    private int Leftscore = 0;
    private int Rightscore = 0;
    public int Topscore = 10;

    private void resetBall(string leftOrRight)
    {
        Xposition = 0f;
        Yposition = 0f;
        scoreField.text = Leftscore + " - " + Rightscore;
        if (leftOrRight == "left")
        {
            xspeed = 2f;
            yspeed = 2f;

        }
        else if (leftOrRight == "right")
        {
            xspeed = -2f;
            yspeed = 2f;
        }
    }
    void Start()
    {
        transform.position = new Vector3(Xposition, Yposition, 0);
    }
    // Update is called once per frame
    void Update()
    {
        Xposition += xspeed * Time.deltaTime;
        Yposition += yspeed * Time.deltaTime;
        transform.position = new Vector3(Xposition, Yposition, 0);
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

    //private void resetBall(string leftOrRight)
    //{
    //    Xposition = 0f;
    //    Yposition = 0f;

    //}

    //// Start is called before the first frame update
    //void Start()
    //{
    //    transform.position = new Vector3(Xposition, Yposition, 0);
    //    xspeed = 3f;
    //    yspeed = 3f;


    //}

    // Update is called once per frame
    //void Update()
    //{
    //    Xposition += xspeed * Time.deltaTime;
    //    Yposition += yspeed * Time.deltaTime;
    //    transform.position = new Vector3(Xposition, Yposition, 0);

    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("horizontalwall")) 
        {
            yspeed = yspeed * -1f; 
        }
        else if (collision.gameObject.CompareTag("verticalwall"))
        {
            yspeed = yspeed * -1f;
        }

        else if (collision.gameObject.CompareTag("leftwall"))
        {
            xspeed = xspeed * -1f;
            Rightscore++;
            scoreField.text = Leftscore + " - " + Rightscore;
            resetBall("left");
        }

        else if (collision.gameObject.CompareTag("rightwall"))
        {
            xspeed = xspeed * -1f;
            Leftscore++;
            scoreField.text = Leftscore + " - " + Rightscore;
            resetBall("right");
        }

        else if (collision.gameObject.CompareTag("Player"))
        {
            xspeed = xspeed * -1.1f;
        }
    }






}
    