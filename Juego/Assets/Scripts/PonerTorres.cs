using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PonerTorres : MonoBehaviour {

    public GameObject torre;
	void OnMouseDown()
    {
        GameObject temp;
        Vector3 pos = this.transform.position;
        pos.y = pos.y + 0.9f;
        temp = Instantiate(torre);
        temp.transform.position = pos;
        temp.layer = 5;
    
	}
}
