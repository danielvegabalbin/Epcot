using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unidad : MonoBehaviour {

    public GameObject ruta;
    private int indice;
    private Vector3 posicion_inicial;
    private Vector3 posicion_siguiente;
    private float vel = 2;
    private float distancia_punto = 0.2f;

    void Start() {
        posicion_inicial = this.transform.position;
        posicion_siguiente = ruta.transform.GetChild(0).position;

    }
    void Update() {
        Vector3 dir = posicion_siguiente - this.transform.position;

        this.transform.position += dir * vel * Time.deltaTime;

        if (dir.magnitude <= distancia_punto)
        {
            if (indice + 1 < ruta.transform.childCount)
            {
                indice++;
                posicion_siguiente = ruta.transform.GetChild(indice).position;
                Debug.Log("xs" + posicion_siguiente.x + "ys" + posicion_siguiente.y + "zs" + posicion_siguiente.z);
            }
            else
            {
                indice = 0;
                this.transform.position = posicion_inicial;
                posicion_siguiente = ruta.transform.GetChild(0).position;

            }
        }
        

    }
   

    void OnTriggerEnter(Collider otro)
    {
        if (otro.gameObject.tag == "bala")
        {
            Destroy(otro.gameObject);
        }
    }

}
