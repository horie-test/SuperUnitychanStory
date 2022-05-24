using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHorizontalScript : MonoBehaviour
{
    // 移動方向（x,y,z）いずれかをUIから指定
    public string dim = "";
    // 移動区間をUIから指定
    public int interval = 0;
    int counter = 0;
    float move = 0.1f; // 移動フレームは固定
    Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (dim)
        {
            case "x":
                position = new Vector3(move, 0, 0);
                break;
            case "y":
                position = new Vector3(0, move, 0);
                break;
            case "z":
                position = new Vector3(0, 0, move);
                break;
            default:
                position = new Vector3(move, 0, 0);
                break;

        }
        
        transform.Translate(position);
        counter++;

        if (counter == interval)
        {
            counter = 0;
            move *= -1;
        }
    }
}
