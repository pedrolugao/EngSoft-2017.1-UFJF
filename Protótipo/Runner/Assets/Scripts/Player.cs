using System;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour {

    public Rigidbody2D rb;
    public GameObject userStatsObj;
    public UserStatistics userStats;
    public Text countMoney;
    public Text countDistance;
    public int totalMoney;
    private int totalDistance = 0;
    public bool noAr;
    private Animator animator;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        userStatsObj = GameObject.Find("UserStats");
        userStats = userStatsObj.GetComponent<UserStatistics>();
        noAr = false;
	}

    public int GetMoney()
    {
        return this.totalMoney;
    }

    public void SetMoney(int money)
    {
        this.totalMoney = money;
    }

    public int GetDistance()
    {
        return this.totalDistance;
    }

    public void SetDistance(int distance)
    {
        this.totalDistance = distance;
    }

    public void adicionarOuro(int x)
    {
        totalMoney += x;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("space"))
        {
            if (noAr == false)
            {
                //noAr = true;
                rb.AddForce(new Vector2(0f, 400f));
                animator.SetTrigger("Jump");
            }
        }

        if (Input.GetKeyDown("escape"))
        {
            Application.LoadLevel(0);
        }

        for (int i = 0; i < Input.touchCount; i++)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
                if (noAr == false)
                {
                    //noAr = true;
                    rb.AddForce(new Vector2(0f, 400f));
                    animator.SetTrigger("Jump");
                }
        }
        //print(rb.position);
        if(rb.position.y <= 0.666)
        {

            noAr = false;
        }
        else
        {
            noAr = true;
        }

        this.totalDistance += 1;
        countDistance.text = "Distancia: " + totalDistance.ToString();
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "coin")
        {
            this.totalMoney += 1;
            countMoney.text = "Moedas: " + totalMoney.ToString();
            other.gameObject.SetActive(false);
        }
        else
        {
            userStats.totalScore += this.totalDistance;
            userStats.lastScore = this.totalDistance;
            userStats.totalMoney += this.totalMoney;
            userStats.lastMoney = this.totalMoney;
            Destroy(this);
            Application.LoadLevel("GameOver");
        }
    }

}
