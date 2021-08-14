using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCylinderNewZ : MonoBehaviour
{
    private Rigidbody rigid;
    private Vector3 defaultPos;

    [SerializeField] private float timez = 2;
    [SerializeField] private float widthz = 4;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        defaultPos = transform.position;
    }

    void FixedUpdate()
    {

        rigid.MovePosition(new Vector3(defaultPos.x, defaultPos.y, defaultPos.z + Mathf.PingPong(Time.time * timez, widthz)));
    }
}
