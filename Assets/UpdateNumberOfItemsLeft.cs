using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpdateNumberOfItemsLeft : MonoBehaviour {

    public readonly string DefaultText = "Number of items left: ";
    public Text Text;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GameObject item = GameObject.FindGameObjectWithTag("MainCamera");
        Game game = item.GetComponent<Game>();
        string numberOfItemsLeft = game.NumberOfItemsLeft.ToString();

        if (game.NumberOfItemsLeft <= 0)
        {
            numberOfItemsLeft = "Failure!";
        }
        Text.text = DefaultText + numberOfItemsLeft;
    }
}
