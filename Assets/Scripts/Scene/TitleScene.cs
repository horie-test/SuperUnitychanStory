﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // クリックした時
        if (Input.GetMouseButtonDown(0))
        {
            // シーンを遷移
            SceneManager.LoadScene("FirstScene");
        }
    }
}
