using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargaPlataforma : MonoBehaviour {
    int tamañolista2;
    public int plataformasiguiente;
    public GameObject Plataforma1;
    public Transform puntoinicio;
    List<GameObject> lista;
    // Use this for initialization
    void Start () {
        GameObject Mapa = GameObject.Find("ControladorMapa");
        Controlador Controlador = Mapa.GetComponent<Controlador>();
        lista = Controlador.plataformas;
        tamañolista2 = lista.Count;
        var PInicio = Instantiate(Plataforma1, puntoinicio.transform.position, puntoinicio.transform.rotation);
        var anclaje = PInicio.gameObject.transform.Find("anclaje1");
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerExit(Collider Personaje)
    {
        var PInicio = Instantiate(Plataforma1, puntoinicio.transform.position, puntoinicio.transform.rotation);
        var anclaje = PInicio.gameObject.transform.Find("anclaje1");

        plataformasiguiente = Random.Range(0, tamañolista2);
        Debug.Log(lista[plataformasiguiente]);
       Instantiate(lista[plataformasiguiente], anclaje.transform.position, anclaje.transform.rotation);
    }
}
