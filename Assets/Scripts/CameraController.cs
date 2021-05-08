using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
	public GameObject player; // 玉のオブジェクト

  private Vector3 offset; // 玉からカメラまでの距離


  void Start()
  {

		//ボールとの距離を取得
    this.player = GameObject.Find("Player");
  	offset = transform.position - player.transform.position;

  }

  void LateUpdate()
  {
  	transform.position = player.transform.position + offset;
  }
}
