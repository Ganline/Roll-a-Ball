using UnityEngine;

public class Jump : MonoBehaviour
{
    // ジャンプする力（上向きの力）を定義
    [SerializeField] private float jumpForcex = 0;
    [SerializeField] private float jumpForcey = 20.0f;
    [SerializeField] private float jumpForcez = 0;

    /// <summary>
    /// Colliderが他のトリガーに入った時に呼び出される
    /// </summary>
    /// <param name="other">当たった相手のオブジェクト</param>
    private void OnTriggerEnter(Collider other)
    {
        // 当たった相手のタグがPlayerだった場合
        if (other.gameObject.CompareTag("Player"))
        {
            // 当たった相手のRigidbodyコンポーネントを取得して、上向きの力を加える
            other.gameObject.GetComponent<Rigidbody>().AddForce(jumpForcex, jumpForcey, jumpForcez, ForceMode.Impulse);
        }
    }
}
