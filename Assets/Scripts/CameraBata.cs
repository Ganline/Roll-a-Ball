using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBata : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
			// transformを取得
			Transform myTransform = this.transform;

			// ローカル座標基準で、現在の回転量へ加算する
			myTransform.Rotate (1.0f, 1.0f, 1.0f);
    }
}
