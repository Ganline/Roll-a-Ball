﻿using UnityEngine;

public class DDManager : MonoBehaviour
{

    public GameObject gameObject;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
