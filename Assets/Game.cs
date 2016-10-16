using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Game : MonoBehaviour {

    public int NumberOfItemsLeft = 10;
    public int NumberOfItemsClicked = 0;
    public bool hasLost = false;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GameObject[] items = GameObject.FindGameObjectsWithTag("Item");
        if(NumberOfItemsLeft <= 0)
        {
            hasLost = true;
        }
    }

    void OnGUI()
    {
        if (hasLost)
        {
            GUI.Label(new Rect(10f, 10f, 100f, 50f), "You lose");
        }
    }
}
