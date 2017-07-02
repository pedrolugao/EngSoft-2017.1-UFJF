using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPoints : MonoBehaviour {

    public Text money;
    public Text distance;
    public Player player;
    public GameObject playerObj;
	// Use this for initialization
	void Start () {
        playerObj = GameObject.Find("Player");
        player = playerObj.GetComponent<Player>();
        money.text = "Moedas: " + player.GetMoney().ToString();
        distance.text = "Distancia: " + player.GetDistance().ToString();
        Destroy(playerObj, 5f);
    }
}
