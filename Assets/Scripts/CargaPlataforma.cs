using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargaPlataforma : MonoBehaviour {
    int tamañolista2;
	// Use this for initialization
	void Start () {
        GameObject Mapa = GameObject.Find("ControladorMapa");
        Controlador Controlador = Mapa.GetComponent<Controlador>();
        var tamañolista = Controlador.plataformas;
        tamañolista2 = tamañolista.Count;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider Personaje)
    {
        Debug.Log(Random.Range(0, tamañolista2));
    }
}
