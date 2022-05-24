using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{
    bool ground;
    // 現在のシーン層をGUI上で入力（デフォルトは0）
    // 入力された数の次のシーンへ進める
    // 未入力（初期値）の場合タイトルに飛ばす
    public int currentStage = 0;
    public AudioClip goalVoice;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //地面に接触していると作動する
        if (ground)
        {
            audioSource.PlayOneShot(goalVoice);
            // 次のシーンへ飛ぶ
            switch (currentStage)
            {
                case 1:
                    SceneManager.LoadScene("SecondScene");
                    break;
                case 2:
                    SceneManager.LoadScene("ThirdScene");
                    break;
                default:
                    SceneManager.LoadScene("TitleScene");
                    break;
            }
            
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
