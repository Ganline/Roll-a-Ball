using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSelectButton : MonoBehaviour
{
    [SerializeField] private GameObject Nextbutton;

    public int stage_num;

    void Start()
    {
        stage_num = PlayerPrefs.GetInt("GoalCount", 0);
    }
    public void LoadingNewScene()
    {
        SceneManager.LoadScene(this.gameObject.name);
    }
    void Update()
    {
        if(stage_num == 1){
            Nextbutton.SetActive(false);
        }
        //初期化
        PlayerPrefs.SetInt("GoalCount", 0);
        PlayerPrefs.Save();
    }
}

