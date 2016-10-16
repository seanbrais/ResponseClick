using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpdateGUI : MonoBehaviour
{


    public readonly string TimeElapsedDefaultText = "Time Elapsed:";
    public Text TimeElapsedText;
    private float timeElapsed = 0f;


    public readonly string ItemsRemainingDefaultText = "Number of items left: ";
    public Text ItemsRemainingText;

    public readonly string ItemsClickedDefaultText = "Number Clicked: ";
    public Text ItemsClickedText;

    private int finalNumberClicked = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject item = GameObject.FindGameObjectWithTag("MainCamera");
        Game game = item.GetComponent<Game>();

        if (game.NumberOfItemsLeft <= 0)
        {
            TimeElapsedText.text = TimeElapsedDefaultText + timeElapsed;
        }
        else
        {
            timeElapsed += Time.deltaTime;
            TimeElapsedText.text = TimeElapsedDefaultText + timeElapsed;
        }


        string numberOfItemsLeft = game.NumberOfItemsLeft.ToString();

        if (game.NumberOfItemsLeft <= 0)
        {
            numberOfItemsLeft = "Failure!";
        }
        ItemsRemainingText.text = ItemsRemainingDefaultText + numberOfItemsLeft;

        ItemsClickedText.text = ItemsClickedDefaultText + game.NumberOfItemsClicked.ToString();


    }

}

