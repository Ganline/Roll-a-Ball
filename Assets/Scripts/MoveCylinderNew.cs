using UnityEngine;
using System.Collections;

public class MoveCylinderNew : MonoBehaviour
{

    private Rigidbody rigid;
    private Vector3 defaultPos;

    [SerializeField] private float timex = 2;
    [SerializeField] private float widthx = 4;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        defaultPos = transform.position;
    }

    void FixedUpdate()
    {

        rigid.MovePosition(new Vector3(defaultPos.x + Mathf.PingPong(Time.time * timex, widthx), defaultPos.y, defaultPos.z));
    }
}
