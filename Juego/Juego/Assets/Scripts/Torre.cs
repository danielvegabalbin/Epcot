using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour {
    public GameObject enemigo;
    private float distancia_umbral = 4;

	void Start () {
		
	}
	
	void Update () {
        float distancia = (enemigo.transform.position - this.transform.position).magnitude;

        if(distancia <= distancia_umbral)
        {
            Debug.DrawLine(this.transform.position, enemigo.transform.position, Color.red);
        }
		
	}
}
