using UnityEngine;
using System.Collections;

public class Moveplanes2 : MonoBehaviour {

	private Rigidbody rigid;
	private Vector3 defaultPos;

	void Start () {
		rigid = GetComponent<Rigidbody>();
		defaultPos = transform.position;
	}

	void FixedUpdate() {
		rigid.MovePosition(new Vector3(defaultPos.x, defaultPos.y - Mathf.PingPong(Time.time * 2, 3), defaultPos.z));
	}
}
