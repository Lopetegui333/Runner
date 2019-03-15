
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargaPlataforma : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hola");
        var script_mapa = GameObject.Find("ControladorMapa").GetComponent<ControladorMapa>();
        int numeroAleatorio = Random.Range(0, script_mapa.plataformas.Count);
        var elementoAleatorio = script_mapa.plataformas[numeroAleatorio];
        var puntoAnclaje = script_mapa.elementoActual.transform.GetChild(0);
        Debug.Log(puntoAnclaje);
        script_mapa.elementoActual = Instantiate(elementoAleatorio, puntoAnclaje.position, puntoAnclaje.rotation);
    }
    void OnTriggerExit(Collider other)
    {
        Destroy(gameObject);
    }
}