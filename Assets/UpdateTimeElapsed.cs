using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpdateTimeElapsed : MonoBehaviour {

    public readonly string DefaultText = "Time Elapsed:";
    public Text Text;
    private float timeElapsed = 0f;

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
            Text.text = DefaultText + timeElapsed;
        }
        else
        {
            timeElapsed += Time.deltaTime;
            Text.text = DefaultText + timeElapsed;
        }
	}
}
