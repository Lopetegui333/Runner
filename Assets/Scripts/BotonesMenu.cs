using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonesMenu : MonoBehaviour {

    public Button BtStart, BtOptions, BtExit;

	// Use this for initialization
	void Start () {
        BtStart.onClick.AddListener(play);
        BtExit.onClick.AddListener(exit);
        BtOptions.onClick.AddListener(options);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void exit()
    {

    }

    void play()
    {

    }

    void options()
    {

    }
}
