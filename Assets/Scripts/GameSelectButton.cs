using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSelectButton : MonoBehaviour
{
    

    void Start()
    {
        
    }
    public void LoadingNewScene()
    {
        SceneManager.LoadScene(this.gameObject.name);
    }
    void Update()
    {
       
    }
}

