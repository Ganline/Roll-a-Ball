﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotater2 : MonoBehaviour
{
	//回転する変数
	private int yvec = -100;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void FixedUpdate()
  {
  	transform.Rotate(new Vector3(0, yvec, 0) * Time.deltaTime);
  }
}
