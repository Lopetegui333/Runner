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
    private Boolean esperarATeclaIzquierda = false;
    private Boolean esperarATeclaDerecha = false;

    public string dcha;
    public string izqd;
    public string jp;
    public string sd;
    
    
    
    // Use this for initialization
    void Start()
    {
        dcha = "dcha";
        izqd = "izq";
        jp = "jp";
        sd = "sd";
        botonSalto.onClick.AddListener(jumpRebind);
        botonAgacharse.onClick.AddListener(agacharseRebind);
        botonIzqd.onClick.AddListener(izquierdaRebind);
        botonDcha.onClick.AddListener(derechaRebind);
        panel.enabled = false;
        panel2.enabled = true;
        Debug.Log(dcha);
        Debug.Log(izqd);
        string tecla_dcha = PlayerPrefs.GetString(dcha,"no");
        if (tecla_dcha!="no") {
            KeyCode dc = (KeyCode)System.Enum.Parse(typeof(KeyCode), tecla_dcha);
            ValorOpciones.DCHA_BUTTON = dc;

        }
        string tecla_izqd = PlayerPrefs.GetString(izqd, "no");
        if (tecla_izqd != "no")
        {
            KeyCode iz = (KeyCode)System.Enum.Parse(typeof(KeyCode), tecla_izqd);
            ValorOpciones.IZQD_BUTTON = iz;

        }
        string tecla_jp = PlayerPrefs.GetString(jp, "no");
        if (tecla_jp != "no")
        {
            KeyCode jump = (KeyCode)System.Enum.Parse(typeof(KeyCode), tecla_jp);
            ValorOpciones.JUMP_BUTTON = jump ;

        }
        string tecla_sd = PlayerPrefs.GetString(sd, "no");
        if (tecla_sd != "no")
        {
            KeyCode slide = (KeyCode)System.Enum.Parse(typeof(KeyCode), tecla_sd);
            ValorOpciones.AGACHARSE_BUTTON = slide;

        }





    }

    // Update is called once per frame
    void Update()
    {
        botonSalto.GetComponentInChildren<Text>().text = ValorOpciones.JUMP_BUTTON.ToString();
        botonAgacharse.GetComponentInChildren<Text>().text = ValorOpciones.AGACHARSE_BUTTON.ToString();
        botonIzqd.GetComponentInChildren<Text>().text = ValorOpciones.IZQD_BUTTON.ToString();
        botonDcha.GetComponentInChildren<Text>().text = ValorOpciones.DCHA_BUTTON.ToString();

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
    void izquierdaRebind()
    {
        panel.enabled = true;
        panel2.enabled = false;
        esperarATeclaIzquierda = true;
    }
    void derechaRebind()
    {
        panel.enabled = true;
        panel2.enabled = false;
        esperarATeclaDerecha = true;
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
            PlayerPrefs.SetString(jp, ValorOpciones.JUMP_BUTTON.ToString());
        }
        var evento2 = Event.current;
        if (evento2.isKey && esperarATeclaAgacharse)
        {
            Debug.Log("Pulsado: " + evento.keyCode);
            ValorOpciones.AGACHARSE_BUTTON = evento.keyCode;
            esperarATeclaAgacharse = false;
            panel.enabled = false;
            panel2.enabled = true;
            PlayerPrefs.SetString(sd, ValorOpciones.AGACHARSE_BUTTON.ToString());
        }

        var evento3 = Event.current;
        if (evento.isKey && esperarATeclaIzquierda)
        {
            Debug.Log("Pulsado: " + evento.keyCode);
            ValorOpciones.IZQD_BUTTON = evento.keyCode;
            esperarATeclaIzquierda= false;
            panel.enabled = false;
            panel2.enabled = true;
            PlayerPrefs.SetString(izqd, ValorOpciones.IZQD_BUTTON.ToString());
            
        }
        var evento4 = Event.current;
        if (evento.isKey && esperarATeclaDerecha)
        {
            Debug.Log("Pulsado: " + evento.keyCode);
            ValorOpciones.DCHA_BUTTON = evento.keyCode;
            esperarATeclaDerecha = false;
            panel.enabled = false;
            panel2.enabled = true;
            PlayerPrefs.SetString(dcha, ValorOpciones.DCHA_BUTTON.ToString());
            
            

        }
    }


}