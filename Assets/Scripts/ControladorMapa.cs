using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMapa : ControladorBasico {
    public override void juegoEnPausa()
    {
   
    }

    public override void juegoRestaurado()
    {
      
    }
    public GameObject Plataforma1;
    public GameObject Plataforma2;
    public GameObject elementoActual;
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
        elementoActual = Instantiate(Plataforma1, puntoinicio.transform.position, puntoinicio.transform.rotation);
        
        
        
        
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
    