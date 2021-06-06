using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSelectButton3 : MonoBehaviour
{
    public void LoadingNewScene()
    {
        SceneManager.LoadScene("Stage3");
    }
}
