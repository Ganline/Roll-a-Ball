using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DropManager1 : MonoBehaviour
{
    //ボールを格納する変数
    public GameObject player;
    //テキストを格納する変数
    public GameObject text;

		private bool isGameOver = false;

		private GoalManager goal;

		//Y座標の値
		private int yp = -15;



    // Start is called before the first frame update
    void Start()
    {
			//インスタンス生成
      goal = gameObject.AddComponent<GoalManager>();
    }

		public void PrintGameOver()
	     {
	         //ゲームオーバーを表示する
	         text.GetComponent<Text>().text = "GameOver...";
	         text.SetActive(true);


	         //ゲームオーバー
	         isGameOver = true;
	     }

    // Update is called once per frame
    void Update()
    {
			if(goal.isGoal == false){
				if(player.transform.position.y < yp)
				{
					PrintGameOver();
				}
			}else{
					text.SetActive(false);
			}

        if(isGameOver && Input.GetMouseButton(0))
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
