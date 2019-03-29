using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Teclas : MonoBehaviour
{
    public Button botonSalto;
    public Button botonAgacharse;
    public Button botonIzqd;
    public Button botonDcha;
    public Canvas panel;
    public Canvas panel2;
    private Boolean esperarATeclaDeSalto = false;
    private Boolean esperarATeclaAgacharse = false;

    // Use this for initialization
    void Start()
    {
        botonSalto.onClick.AddListener(jumpRebind);
        botonAgacharse.onClick.AddListener(agacharseRebind);
        panel.enabled = false;
        panel2.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        botonSalto.GetComponentInChildren<Text>().text = ValorOpciones.JUMP_BUTTON.ToString();
        botonAgacharse.GetComponentInChildren<Text>().text = ValorOpciones.AGACHARSE_BUTTON.ToString();
        botonIzqd.GetComponentInChildren<Text>().text = ValorOpciones.IZQD_BUTTON.ToString();

    }

    void jumpRebind()
    {
        panel.enabled = true;
        panel2.enabled = false;
        esperarATeclaDeSalto = true;
        
    }
    void agacharseRebind()
    {
        panel.enabled = true;
        panel2.enabled = false;
        esperarATeclaAgacharse = true;
    }

    private void OnGUI()
    {
        var evento = Event.current;
        if (evento.isKey && esperarATeclaDeSalto)
        {
            Debug.Log("Pulsado: " + evento.keyCode);
            ValorOpciones.JUMP_BUTTON = evento.keyCode;
            esperarATeclaDeSalto = false;
            panel.enabled = false;
            panel2.enabled = true;
        }
        var evento2 = Event.current;
        if (evento2.isKey && esperarATeclaAgacharse)
        {
            Debug.Log("Pulsado: " + evento.keyCode);
            ValorOpciones.AGACHARSE_BUTTON = evento.keyCode;
            esperarATeclaAgacharse = false;
            panel.enabled = false;
            panel2.enabled = true;
        }
    }


}