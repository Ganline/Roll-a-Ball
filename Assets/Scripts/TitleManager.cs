using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleManager : MonoBehaviour
{
    [SerializeField] private GameObject[] openstages = new GameObject[19];
    int goalcounts;

    // Start is called before the first frame update
    void Start()
    {
        goalcounts = PlayerPrefs.GetInt("GoalCount", 0);
        for (int i = 0; i < goalcounts; i++)
        {     
            openstages[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
