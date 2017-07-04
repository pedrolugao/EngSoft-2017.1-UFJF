using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using UnityEngine;
public class GameManager : MonoBehaviour
{

    public GameObject[] Enemies;
    public GameObject[] Coins;
    public GameObject Player;
    public float timeSpace = 3f;
    private float timer;

    // Use this for initialization
    void Start()
    {
        CreateObjects();
        timer = Time.time + timeSpace;
    }

    void CreateObjects()
    {
        if (Random.Range(0f, 5f) < 1)
        {
            Instantiate(Coins[0], new Vector3(20f, 4.0f, 0f), Quaternion.identity);
        }
        else if (Random.Range(0f, 5f) < 2)
        {
            if (Random.Range(0f, 2f) < 1)
            {
                Instantiate(Enemies[2], new Vector3(20f, 4.2f, 0f), Quaternion.identity);
            }
            else
            {
                Instantiate(Enemies[3], new Vector3(20f, 4.2f, 0f), Quaternion.identity);
            }
        }
        else
        {
            if (Random.Range(0f, 2f) < 1)
            {
                Instantiate(Enemies[0], new Vector3(20f, 1.0f, 0f), Quaternion.identity);
            }
            else
            {
                Instantiate(Enemies[1], new Vector3(20f, 1.0f, 0f), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timer)
        {
            CreateObjects();
            timer = Time.time + timeSpace;
        }
    }
}
