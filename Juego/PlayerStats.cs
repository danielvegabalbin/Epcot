﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public static int Money;
    public int startMoney = 100;
    public static int Lives;
    public int startLives = 20;
  
    // Use this for initialization
    void Start()
    {
        Money = startMoney;
        Lives = startLives;
    }

    
    
	
	// Update is called once per frame
	void Update () {
		
	}
}
