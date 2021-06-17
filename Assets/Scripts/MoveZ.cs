using UnityEngine;
using System.Collections;

public class MoveZ : MonoBehaviour
{

    private Rigidbody rigid;
    private Vector3 defaultPos;

    [SerializeField] private float timespeed = 2;
    [SerializeField] private float width = 3;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        defaultPos = transform.position;
    }

    void FixedUpdate()
    {
        rigid.MovePosition(new Vector3(defaultPos.x, defaultPos.y, defaultPos.z + Mathf.PingPong(Time.time * timespeed, width)));
    }
}
