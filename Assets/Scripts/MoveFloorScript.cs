using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloorScript : MonoBehaviour
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
        Vector3 position = new Vector3(0, 0, move);
        transform.Translate(position);
        counter++;

        if (counter == 300)
        {
            counter = 0;
            move *= -1;
        }
    }
}
