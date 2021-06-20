using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BatteryScript : MonoBehaviour
{
    public GameObject Bullet; // 弾
    [SerializeField] private float aftersecond = 1;
    [SerializeField] private float second = 1;
    [SerializeField] private float bulletforce = 400;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shot", aftersecond, second); // 1秒後にsecond秒ごとにShotを繰り返す 
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Shot() // 弾を発射する処理
    {
        GameObject Bullets = Instantiate(Bullet.gameObject, transform.position, transform.rotation); // 弾を砲台と同じ場所、同じ向きに生成する
        Vector3 Force; // 弾にかける力
        Force = transform.forward * bulletforce; // 弾にかける力を砲台の前方向にする
        Bullets.GetComponent<Rigidbody>().AddForce(Force); // 弾に力をかける
        Destroy(Bullets.gameObject, 15); // 弾を2秒後に消す
    }
}