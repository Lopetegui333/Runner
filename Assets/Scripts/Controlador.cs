using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : ControladorBasico {
    public override void juegoEnPausa()
    {
        throw new System.NotImplementedException();
    }

    public override void juegoRestaurado()
    {
        throw new System.NotImplementedException();
    }
    public GameObject Plataforma1;
    public GameObject Plataforma2;
    public Transform puntoinicio;
    public Transform puntoanclaje1;
    public List<GameObject> plataformas = new List<GameObject>();
    int tamañolista;
    int Cargar;
    


    // Use this for initialization
    void Start () {
   
       
        base.Start();
        tamañolista = plataformas.Count;
        //Debug.Log(tamañolista);
        var PInicio = Instantiate(Plataforma1, puntoinicio.transform.position, puntoinicio.transform.rotation);
        var anclaje = PInicio.gameObject.transform.Find("anclaje1");
        GameObject Control = GameObject.Find("Carga");
        CargaPlataforma CargaPlataforma = Control.GetComponent<CargaPlataforma>();
        int cargar = CargaPlataforma.plataformasiguiente;
        
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
    