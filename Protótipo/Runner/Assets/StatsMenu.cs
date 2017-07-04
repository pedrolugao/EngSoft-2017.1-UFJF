using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsMenu : MonoBehaviour {

    public Text money;
    public Text distance;
    public Text totalMoney;
    public Text totalDistance;
    public GameObject userStatsObj;
    public UserStatistics userStats;
    // Use this for initialization
    void Start()
    {
        userStatsObj = GameObject.Find("UserStats");
        userStats = userStatsObj.GetComponent<UserStatistics>();
        money.text = "Moedas: " + userStats.lastMoney.ToString();
        distance.text = "Distancia: " + userStats.lastScore.ToString();
        totalMoney.text = "Total de moedas: " + userStats.totalMoney.ToString();
        totalDistance.text = "Distancia total: " + userStats.totalScore.ToString();
    }
}
