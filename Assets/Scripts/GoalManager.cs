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
    int stage_num;
    int goalcount;

    public int goalcountmax = 0;

    // Start is called before the first frame update
    void Start()
    {
        //ad = GameObject.Find("Ad").GetComponent<Adtest>();
        num = SceneManager.GetActiveScene().buildIndex;
        int stage_num = num - 1;
        text.SetActive(false);
        goalcount = PlayerPrefs.GetInt("GoalCount", 0);
        goalcountmax = Mathf.Max(stage_num, goalcount);
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

            if (goalcountmax == 1)
            {
                //ステージ解放用の値
                PlayerPrefs.SetInt("GoalCount", 1);
                //PlayerPrefsをセーブする         
                PlayerPrefs.Save();
            }
            if (goalcountmax == 2)
            {
                //ステージ解放用の値
                PlayerPrefs.SetInt("GoalCount", 2);
                //PlayerPrefsをセーブする         
                PlayerPrefs.Save();
            }
            if (goalcountmax == 3)
            {
                //ステージ解放用の値
                PlayerPrefs.SetInt("GoalCount", 3);
                //PlayerPrefsをセーブする         
                PlayerPrefs.Save();
            }
            if (goalcountmax == 4)
            {
                //ステージ解放用の値
                PlayerPrefs.SetInt("GoalCount", 4);
                //PlayerPrefsをセーブする         
                PlayerPrefs.Save();
            }
            if (goalcountmax == 5)
            {
                //ステージ解放用の値
                PlayerPrefs.SetInt("GoalCount", 5);
                //PlayerPrefsをセーブする         
                PlayerPrefs.Save();
            }
            if (goalcountmax == 6)
            {
                //ステージ解放用の値
                PlayerPrefs.SetInt("GoalCount", 6);
                //PlayerPrefsをセーブする         
                PlayerPrefs.Save();
            }
            if (goalcountmax == 7)
            {
                //ステージ解放用の値
                PlayerPrefs.SetInt("GoalCount", 7);
                //PlayerPrefsをセーブする         
                PlayerPrefs.Save();
            }
            if (goalcountmax == 8)
            {
                //ステージ解放用の値
                PlayerPrefs.SetInt("GoalCount", 8);
                //PlayerPrefsをセーブする         
                PlayerPrefs.Save();
            }
            if (goalcountmax == 9)
            {
                //ステージ解放用の値
                PlayerPrefs.SetInt("GoalCount", 9);
                //PlayerPrefsをセーブする         
                PlayerPrefs.Save();
            }
            if (goalcountmax == 10)
            {
                //ステージ解放用の値
                PlayerPrefs.SetInt("GoalCount", 10);
                //PlayerPrefsをセーブする         
                PlayerPrefs.Save();
            }
            if (goalcountmax == 11)
            {
                //ステージ解放用の値
                PlayerPrefs.SetInt("GoalCount", 11);
                //PlayerPrefsをセーブする         
                PlayerPrefs.Save();
            }
            if (goalcountmax == 12)
            {
                //ステージ解放用の値
                PlayerPrefs.SetInt("GoalCount", 12);
                //PlayerPrefsをセーブする         
                PlayerPrefs.Save();
            }
            if (goalcountmax == 13)
            {
                //ステージ解放用の値
                PlayerPrefs.SetInt("GoalCount", 13);
                //PlayerPrefsをセーブする         
                PlayerPrefs.Save();
            }
            if (goalcountmax == 14)
            {
                //ステージ解放用の値
                PlayerPrefs.SetInt("GoalCount", 14);
                //PlayerPrefsをセーブする         
                PlayerPrefs.Save();
            }
            if (goalcountmax == 15)
            {
                //ステージ解放用の値
                PlayerPrefs.SetInt("GoalCount", 15);
                //PlayerPrefsをセーブする         
                PlayerPrefs.Save();
            }
            if (goalcountmax == 16)
            {
                //ステージ解放用の値
                PlayerPrefs.SetInt("GoalCount", 16);
                //PlayerPrefsをセーブする         
                PlayerPrefs.Save();
            }
            if (goalcountmax == 17)
            {
                //ステージ解放用の値
                PlayerPrefs.SetInt("GoalCount", 17);
                //PlayerPrefsをセーブする         
                PlayerPrefs.Save();
            }
            if (goalcountmax == 18)
            {
                //ステージ解放用の値
                PlayerPrefs.SetInt("GoalCount", 18);
                //PlayerPrefsをセーブする         
                PlayerPrefs.Save();
            }
            if (goalcountmax == 19)
            {
                //ステージ解放用の値
                PlayerPrefs.SetInt("GoalCount", 19);
                //PlayerPrefsをセーブする         
                PlayerPrefs.Save();
            }
            if (goalcountmax == 20)
            {
                //ステージ解放用の値
                PlayerPrefs.SetInt("GoalCount", 20);
                //PlayerPrefsをセーブする         
                PlayerPrefs.Save();
            }
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
