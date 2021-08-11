using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    [SerializeField] private Button sb;
    [SerializeField] private GameObject sp;

    // Start is called before the first frame update
    void Start()
    {
        sp.SetActive(true);
        Time.timeScale = 0;  // 時間停止
        sb.onClick.AddListener(gamestart);
    }

    // Update is called once per frame
    void gamestart()
    {
        sp.SetActive(false);
        Time.timeScale = 1;  // 開始
    }
}
