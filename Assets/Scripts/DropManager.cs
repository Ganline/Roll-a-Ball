using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DropManager : MonoBehaviour
{
    //ボールを格納する変数
    public GameObject player;
    //テキストを格納する変数
    public GameObject text;

    private bool isGameOver = false;



    // Start is called before the first frame update
    void Start()
    {

    }

    public void PrintGameOver()
    {
        //ゲームオーバーを表示する
        text.GetComponent<Text>().text = "GameOver...";
        text.SetActive(true);


        //ゲームオーバー
        isGameOver = true;
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            PrintGameOver();
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (isGameOver && Input.GetMouseButton(0))
        {
            Restart();
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
}
