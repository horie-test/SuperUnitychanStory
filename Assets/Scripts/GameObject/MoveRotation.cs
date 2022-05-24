using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRotation : MonoBehaviour
{
    // 回転軸をUIから指定
    public string dim = "";
    // 回転度数をUIから指定
    public float rotate = 0;
    Vector3 euler;

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
                euler = new Vector3(rotate, 0, 0);
                break;
            case "y":
                euler = new Vector3(0, rotate, 0);
                break;
            case "z":
                euler = new Vector3(0, 0, rotate);
                break;
            default:
                euler = new Vector3(rotate, 0, 0);
                break;
        }
        transform.Rotate(euler);
    }
}
