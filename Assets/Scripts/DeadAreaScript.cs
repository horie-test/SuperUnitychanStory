using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadAreaScript : MonoBehaviour
{
    //地面に接触しているか否か
    bool ground;
    public GameObject playerObj = GameObject.Find("unitychan");

    // Start is called before the first frame update
    void Start()
    {
        // do nothing
    }

    // Update is called once per frame
    void Update()
    {
        //地面に接触していると作動する
        if (ground)
        {
            // リスタート
            playerObj.transform.position = new Vector3(0, 1, 0);
        }
    }

    //Planに触れている間作動
    void OnCollisionStay(Collision col)
    {
        ground = true;
    }

    //Planから離れると作動
    void OnCollisionExit(Collision col)
    {
        ground = false;
    }
}
