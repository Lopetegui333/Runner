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
   
    // Use this for initialization
    void Start () {
        base.Start();

        var PInicio = Instantiate(Plataforma1, puntoinicio.transform.position, puntoinicio.transform.rotation);
        var anclaje = PInicio.gameObject.transform.Find("anclaje1");
        Instantiate(Plataforma2, anclaje.transform.position, anclaje.transform.rotation);
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
