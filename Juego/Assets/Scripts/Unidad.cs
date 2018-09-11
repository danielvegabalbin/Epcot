using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unidad : MonoBehaviour {

    public GameObject ruta;
    private int indice;
    private Vector3 posicion_siguiente;
    private float vel = 1;
    private float distancia_punto = 0.5f;

	void Start () {
        posicion_siguiente = ruta.transform.GetChild(0).position;
		
	}
	void Update () {
        Vector3 dir = posicion_siguiente - this.transform.position;

        this.transform.position += dir * vel * Time.deltaTime;

        if (dir.magnitude <= distancia_punto)
        {
            if(indice+1 < ruta.transform.childCount)
            {
                indice++;
                posicion_siguiente = ruta.transform.GetChild(indice).position;
                Debug.Log("xs" + posicion_siguiente.x + "ys" + posicion_siguiente.y + "zs" + posicion_siguiente.z);
            }
        }
		
	}
}
