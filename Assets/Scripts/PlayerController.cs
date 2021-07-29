using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed; // 動く速さ
    public Text timeText; // タイムアタックの UI
    public Text besttimeText;
    public Text goalText;//ゴール表示の	UI
    public Text dropText;//落下した時の処理　UI
    [SerializeField] public FloatingJoystick joystick;

    private Rigidbody rb; // Rididbody
    private float time; //　タイムアタック用
    private float highscore = 0;


    [SerializeField] private GoalManager goal; //goalmanagerを呼び出す
                                               // Start is called before the first frame update
    void Start()
    {

        // Rigidbody を取得
        rb = GetComponent<Rigidbody>();
        // UI を初期化
        time = 0.0f;

        timeText.text = "";
        besttimeText.text = "";
        goalText.text = "";
        dropText.text = "";
        //インスタンス生成
        //goal = gameObject.AddComponent<GoalManager>();
        if (PlayerPrefs.HasKey(SceneManager.GetActiveScene().buildIndex.ToString()))
        {
            highscore = PlayerPrefs.GetFloat(SceneManager.GetActiveScene().buildIndex.ToString());
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // カメラの方向を取得
        var cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;
        //ジョイスティックからの入力を取得
        Vector3 direction = cameraForward * joystick.Vertical + Camera.main.transform.right * joystick.Horizontal;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);

        //タイムアタック
        if (highscore == 0)
        {
            besttimeText.text = "";
        }
        else
        {
            besttimeText.text = "BestTime:" + highscore;
        }
        if (goal.isGoal == false)
        {
            time += Time.deltaTime;
            timeText.text = time.ToString("F2");
        }
        if (goal.isGoal)
        {
            if (highscore > time)
            {
                PlayerPrefs.SetFloat(SceneManager.GetActiveScene().buildIndex.ToString(), time);
            }
        }
    }
}
