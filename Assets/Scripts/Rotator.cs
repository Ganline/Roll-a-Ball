using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float rotatex = 15;
    [SerializeField] private float rotatey = 30;
    [SerializeField] private float rotatez = 45;
    void Update()
    {
        transform.Rotate(new Vector3(rotatex, rotatey, rotatez) * Time.deltaTime);
    }
}
