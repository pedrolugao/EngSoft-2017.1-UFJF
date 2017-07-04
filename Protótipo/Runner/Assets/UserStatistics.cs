using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserStatistics : MonoBehaviour {


    public int totalScore = 0;
    public int lastScore = 0;
    public int totalMoney = 0;
    public int lastMoney = 0;

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(this);
    }
}