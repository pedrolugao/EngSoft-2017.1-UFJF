using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using UnityEngine;
public class GameManager : MonoBehaviour {

    public GameObject[] Enemies;
    public GameObject[] Coins;
    public GameObject Player;
    public float timeSpace = 3f;
    private float timer;
    public static float tempoJogo = 0;

	// Use this for initialization
	void Start () {
        CreateObjects(0);
        timer = Time.time + timeSpace;
	}
	
    void CreateObjects(float time)
    {
        float numberMax = 5f;
        if (Random.Range(0f, numberMax) < 1)
        {
            Instantiate(Coins[0], new Vector3(20f, 2.2f, 0f), Quaternion.identity);
        }
        else if (Random.Range(0f, numberMax) < 2)
        {
            Instantiate(Enemies[0], new Vector3(20f, 2.2f, 0f), Quaternion.identity);
        }
        else
        {
            Instantiate(Enemies[0], new Vector3(20f, 0.63f, 0f), Quaternion.identity);
        }
    }

	// Update is called once per frame
	void Update () {
		if(Time.time >= timer)
        {
            CreateObjects(timer);
            timer = Time.time + timeSpace;
            tempoJogo = tempoJogo + timeSpace;
            timeSpace = 3f - (tempoJogo / 10);
            if (timeSpace < 1.5f) timeSpace = 1.5f;
        }
	}
}
