﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //config parameters
    [SerializeField] float minX = 22f;
    [SerializeField] float maxX = 252.9f;

    [SerializeField] float screenWidthInUnits = 16f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePosInUnits = Input.mousePosition.x;

        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits, minX, maxX);
        Debug.Log(mousePosInUnits + minX + maxX);
        transform.position = paddlePos;
    }
}
