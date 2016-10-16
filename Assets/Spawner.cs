using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public float timeElapsed;
    public float maxTimeSpawn = 1f;
    public float minTimeSpawn = .2f;
    public float lessenTimeConstant = .02f;
    System.Random RandomGenerator = new System.Random();
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timeElapsed += Time.deltaTime;

        if(timeElapsed >= maxTimeSpawn)
        {
            Vector3 stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
            Camera camera = GetComponent<Camera>();
            float x = (float)GetRandomNumber(-stageDimensions.x, stageDimensions.x);
            float y = (float)GetRandomNumber(-stageDimensions.y, stageDimensions.y);
            GameObject go = (GameObject)Instantiate(Resources.Load("Item"), new Vector3(x, y), Quaternion.identity);
            timeElapsed = 0;

            if(maxTimeSpawn < minTimeSpawn)
            {
                maxTimeSpawn = minTimeSpawn;
            }
            else
            {

                maxTimeSpawn -= lessenTimeConstant;

            }
        }

	}

    public double GetRandomNumber(double minimum, double maximum)
    {
        return RandomGenerator.NextDouble() * (maximum - minimum) + minimum;
    }
}
