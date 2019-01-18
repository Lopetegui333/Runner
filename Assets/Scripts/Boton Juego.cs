using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotonJuego : MonoBehaviour {

    public Button BtMenu;
    // Use this for initialization
    void Start () {
       BtMenu.onClick.AddListener(Menu);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
