using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketEffect : MonoBehaviour
{
    [SerializeField] private GameObject ExplosionSystem;
    // Start is called before the first frame update
    void Start()
    {
        ExplosionSystem.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        // 当たった相手のタグがPlayerだった場合
        if (other.gameObject.CompareTag("Player"))
        {
            ExplosionSystem.SetActive(true);
        }
    }
}
