using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadAreaScript : MonoBehaviour
{
    bool ground;
    public AudioClip deathVoice;
    AudioSource audioSource;
    GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("unitychan");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        System.Console.WriteLine("Update()");
        //地面に接触していると作動する
        if (ground)
        {
            // リスタート
            player.transform.position = new Vector3(0, 5, 0);
            audioSource.PlayOneShot(deathVoice);
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
