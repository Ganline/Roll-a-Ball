using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSelectButton : MonoBehaviour
{
    public void LoadingNewScene()
    {
        SceneManager.LoadScene(this.gameObject.name);
    }
}

