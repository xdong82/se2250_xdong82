﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class down : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;
        float speed = 0.1f;
        if (Input.GetKey(KeyCode.DownArrow))
            move = Vector3.down;
        gameObject.transform.position = move * speed + gameObject.transform.position;
    }
}
