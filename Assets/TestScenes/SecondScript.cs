﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecondScript : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("MainScene");
    }
}
