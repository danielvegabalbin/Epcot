﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {
    
    private GameObject objetivo;
    private float velocidad = 2;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 direccion;
        if (objetivo != null)
        {
            direccion = objetivo.transform.position - this.transform.position;
            this.transform.position += velocidad * direccion * Time.deltaTime;

        }

    }
    public void ActivarBala(Torre torre)
    {
        objetivo = torre.enemigo;
    }
}
