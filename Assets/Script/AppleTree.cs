﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    // Apple Prefab (makes apples appear)
    public GameObject applePrefab;

    //AppleTree Speed
    public float speed = 1f;

    //AppleTree Distance to turn around
    public float leftAndRightEdge = 10f;

    //Chance that AppleTree will change direction(10% chance)
    public float chanceToChangeDirections = 0.1f;

    //Rate that the Apples appear
    public float secondsBetweenAppleDrops = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //Drops apples every second
        
    }

    // Update is called once per frame
    void Update()
    {
        //Basic Movement

        //current position of the AppleTree
        Vector3 pos = transform.position;
        //movement is time based 
        pos.x += speed * Time.deltaTime;
        //moves AppleTree to new position
        transform.position = pos;

        //Changing Direction
        if (pos.x < -leftAndRightEdge)
        {
            //Move right
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge)
        {
            //Move left
            speed = -Mathf.Abs(speed);
        }
    }
}
