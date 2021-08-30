using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;


public class DropManager : MonoBehaviour
{
    //ボールを格納する変数
    public GameObject player;
    //テキストを格納する変数
    public GameObject text;

    private bool isGameOver = false;

    public AudioClip dropsound;

    Adtest ad;

    int value = 0;


    // Start is called before the first frame update
    void Start()
    {
        ad = GameObject.Find("Ad").GetComponent<Adtest>();
        
    }

    public void PrintGameOver()
    {
        //ゲームオーバーを表示する
        text.GetComponent<Text>().text = "GameOver...";
        text.SetActive(true);

        value = new System.Random().Next(0, 10);
        //ゲームオーバー
        isGameOver = true;
        if(value >= 5)
        {
            ad.isFin = true;
        }
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(dropsound, player.transform.position);
            PrintGameOver();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver && Input.GetMouseButton(0) && value < 5)
        {
            OnGUI();
        }

        if (ad.isFin)
        {
            Restart();
            ad.isFin = false;
        }
    }

    //シーンを再読み込みする
    public void Restart()
    {
        // 現在のScene名を取得する
        Scene loadScene = SceneManager.GetActiveScene();
        // Sceneの読み直し
        SceneManager.LoadScene(loadScene.name);
    }

    //ゲームオーバーしているかどうか確認
    public bool IsGameOver()
    {
        return isGameOver;
    }

    private void OnGUI()
    {
        var options = new[]
        {
            GUILayout.Width( Screen.width ),
            GUILayout.Height( Screen.height),
        };
        if (isGameOver && Input.GetMouseButton(0) && value < 5)
        {
            ad.ShowRewardedAd();
        }
    }
}
