﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVerticalScript : MonoBehaviour
{
    int counter = 0;
    float move = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = new Vector3(0, move, 0);
        transform.Translate(position);
        counter++;

        if (counter == 300)
        {
            counter = 0;
            move *= -1;
        }
    }
}
