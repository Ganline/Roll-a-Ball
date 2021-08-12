using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class GoalManager : MonoBehaviour
{
    //ゴールを格納するための変数
    public GameObject player;
    //テキストを格納するための変数
    public GameObject text;

    public AudioClip goalsound;

    //広告用
    //Adtest ad;

    //Goalしたかどうか判定する
    public bool isGoal = false;

    int num;

    // Start is called before the first frame update
    void Start()
    {
        //ad = GameObject.Find("Ad").GetComponent<Adtest>();
        num = SceneManager.GetActiveScene().buildIndex;
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Goalした後で画面をクリックされたとき
        if (isGoal && Input.GetMouseButton(0))
        {
            //OnGUI();
            Nextstart();
        }

        /*if (ad.isFin)
        {
            Nextstart();
            ad.isFin = false;
        }*/
    }

    //当たり判定関数
    private void OnTriggerEnter(Collider other)
    {
        //当たってきたオブジェクトがボールだったとき
        if (other.name == player.name)
        {
            //テキストの内容を変更する
            text.GetComponent<Text>().text = "Goal!!!\n画面クリックで再スタート";
            //テキストをオンにして非表示→表示にする
            text.SetActive(true);

            //Goal判定をTrueにする
            isGoal = true;

            AudioSource.PlayClipAtPoint(goalsound, transform.position);

            //ステージ解放用の値
            PlayerPrefs.SetInt("GoalCount", 1);
            //PlayerPrefsをセーブする         
            PlayerPrefs.Save();
        }
    }

    //シーンを再読み込みする
    private void Nextstart()
    {
        // 次のSceneのビルド番号を取得する
        num += 1;
        // 次のSceneの読み込み
        SceneManager.LoadScene(num);
    }
    /*private void OnGUI()
    {
        var options = new[]
        {
            GUILayout.Width( Screen.width ),
            GUILayout.Height( Screen.height),
        };
        if (isGoal == true)
        {
            ad.ShowRewardedAd();
        }

    }*/
}
