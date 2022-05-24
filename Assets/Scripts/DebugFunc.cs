using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugFunc : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        // マウスクリックで初期位置へリスポーン
        if (Input.GetMouseButtonDown(0))
        {
            player.transform.position = new Vector3(0, 2, 0);
        }
        
    }
}
