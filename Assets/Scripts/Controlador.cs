using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : ControladorBasico
{

    public GameObject elementoInicial;
    public GameObject elementoSiguiente;
    public Transform puntoInicial;
    public List<ControladorBasico> controladores;
    

    // Use this for initialization
    void Start()
    {
        base.Start();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void juegoEnPausa()
    {

    }

    public override void juegoRestaurado()
    {

    }
}