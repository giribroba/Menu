﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInicial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChamaHistoria()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("CaminhoH");
    }
}
