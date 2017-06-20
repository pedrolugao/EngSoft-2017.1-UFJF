using System;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour {

    public Rigidbody rb;
    public Text countMoney;
    public Text countDistance;
    public int totalMoney;
    private int totalDistance = 0;
    private bool noAr;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        DontDestroyOnLoad(this);
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
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            if (noAr == false)
            {
                noAr = true;
                rb.AddForce(new Vector3(0f, 400f, 0f));
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
                    noAr = true;
                    rb.AddForce(new Vector3(0f, 400f, 0f));
                }
        }
        print(rb.position);
        if(rb.position.y <= 0.63)
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            this.totalMoney += 1;
            countMoney.text = "Moedas: " + totalMoney.ToString();
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("enemy"))
        {
            //this.gameObject.SetActive(false);
            Application.LoadLevel("GameOver");
        }
    }

}
