using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
		public float speed; // 動く速さ
    public Text timeText; // タイムアタックの UI
		public Text goalText;//ゴール表示の	UI
		public Text dropText;//落下した時の処理　UI

    private Rigidbody rb; // Rididbody
		private float time; //　タイムアタック用
		private GoalManager goal;　//goalmanagerを呼び出す
  // Start is called before the first frame update
  void Start()
  {

		// Rigidbody を取得
		rb = GetComponent<Rigidbody>();
		// UI を初期化
    time = 0.0f;

		timeText.text = "";
		goalText.text = "";
		dropText.text = "";
		//インスタンス生成
		goal = gameObject.AddComponent<GoalManager>();
  }

  // Update is called once per frame
  void FixedUpdate()
  {
		// カーソルキーの入力を取得
		var moveHorizontal = Input.GetAxis("Horizontal");
		var moveVertical = Input.GetAxis("Vertical");

		// カーソルキーの入力に合わせて移動方向を設定
		var movement = new Vector3(moveHorizontal, 0, moveVertical);

		// Ridigbody に力を与えて玉を動かす
	 	rb.AddForce(movement * speed);

		//タイムアタック
		if(goal.isGoal == false){
			time += Time.deltaTime;
    	timeText.text = time.ToString("F2");
		}
  }
}
