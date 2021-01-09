﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene(1);
    }

}
