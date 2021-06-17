using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotater : MonoBehaviour
{
    //回転する変数
    [SerializeField] private int xvec = 0;
    [SerializeField] private int yvec = 80;
    [SerializeField] private int zvec = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(xvec, yvec, zvec) * Time.deltaTime);
    }
}
