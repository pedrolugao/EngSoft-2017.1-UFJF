using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPoints : MonoBehaviour {

    public Text money;
    public Text distance;
    public GameObject userStatsObj;
    public UserStatistics userStats;
    // Use this for initialization
    void Start () {
        userStatsObj = GameObject.Find("UserStats");
        userStats = userStatsObj.GetComponent<UserStatistics>();
        money.text = "Moedas: " + userStats.lastMoney.ToString();
        distance.text = "Distancia: " + userStats.lastScore.ToString();
    }
}
