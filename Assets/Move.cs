using UnityEngine;
using System.Collections;
using System;

public class Move : MonoBehaviour
{
    public float TimeExisted { get; set; }

    public float IncreaseDifficultyTime = 1f;

    private int SpeedModifier;

    private System.Random generator = new System.Random();

    private bool DirectionModifier;

    public int MaxSpeed = 5;
    
    // Use this for initialization
    void Start()
    {
        SpeedModifier = new System.Random().Next(-MaxSpeed, MaxSpeed);
        DirectionModifier = GoRight();
    }

    // Update is called once per frame
    void Update()
    {

        GameObject item = GameObject.FindGameObjectWithTag("MainCamera");
        Game game = item.GetComponent<Game>();

        Vector3 stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        if (Math.Abs(this.transform.position.x) > stageDimensions.x || Math.Abs(this.transform.position.y) > stageDimensions.y)
        {

            game.NumberOfItemsLeft--;
            Destroy(this.gameObject);
        }

            TimeExisted += Time.deltaTime;
        this.transform.Translate(Vector2.up * Time.deltaTime * SpeedModifier);

        if(TimeExisted >= IncreaseDifficultyTime)
        {
            if (DirectionModifier)
            {
                this.transform.Translate(Vector2.right * Time.deltaTime * SpeedModifier);
            }
            else
            {
                this.transform.Translate(Vector2.left * Time.deltaTime * SpeedModifier);
            }
           

        }

    }

    void OnMouseDown()
    {
        GameObject item = GameObject.FindGameObjectWithTag("MainCamera");
        Game game = item.GetComponent<Game>();

        if (game.NumberOfItemsLeft > 0)
        {
            game.NumberOfItemsClicked++;
        }

        Destroy(this.gameObject);
    }


    public bool GoRight()
    {
        return this.generator.Next(0, 2) == 0;
    }
}