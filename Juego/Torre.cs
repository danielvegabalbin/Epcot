using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour {
    public GameObject enemigo;
    private bool esta_activa;
    private float distancia_umbral = 4;

    public bool Esta_activa
    {
        get
        {
            return esta_activa;
        }

        set
        {
            esta_activa = value;
        }
    }

    void Start () {
		
	}
	
	void Update () {
        enemigo = BuscarEnemigoCercano();
        if (enemigo != null)
        {
            Disparar();
            Debug.DrawLine(this.transform.position, enemigo.transform.position, Color.white);
        }
		
	}

    void Disparar()
    {
        GameObject obj = (GameObject)Instantiate(GameObject.Find("bala"),this.transform.position, Quaternion.identity);
        Bala bala = obj.GetComponent<Bala>();
        bala.ActivarBala(this);
    }

    GameObject BuscarEnemigoCercano()
    {
        ArrayList enemigos = PoolingdeUnidades.unidades;
        GameObject temp;
        foreach (Object item in enemigos)
        {
            temp = (GameObject)item;
            if (Vector3.Distance(temp.transform.position, this.transform.position) < distancia_umbral)
            {
                return temp;
            }
        }
        return null;
    }
}
    
