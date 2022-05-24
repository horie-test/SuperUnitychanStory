using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDirection : MonoBehaviour
{
    // 移動方向（x,y,z）いずれかをUIから指定
    public string dim = "";
    // 移動秒数をUIから指定
    public int timer = 0;
    // 移動量をUIから指定
    public float transition = 0f;
    int counter = 0;
    
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
                position = new Vector3(transition, 0, 0);
                break;
            case "y":
                position = new Vector3(0, transition, 0);
                break;
            case "z":
                position = new Vector3(0, 0, transition);
                break;
            default:
                position = new Vector3(transition, 0, 0);
                break;

        }
        
        transform.Translate(position);
        counter++;

        if (counter == timer)
        {
            counter = 0;
            transition *= -1;
        }
    }
}
