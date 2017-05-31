using System;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour {

    public Rigidbody rb;
    public int totalMoney;
    private int totalDistance = 0;
    private bool noAr;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        noAr = false;
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
	}

    int getDistance()
    {
        return this.totalDistance;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            this.totalMoney += 1;
            updateText();
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("enemy"))
        {
            this.gameObject.SetActive(false);
            Application.LoadLevel(0);
            other.gameObject.GetComponent<Rigidbody>().AddForce(200f, 0f, 0f);
        }
    }

    private void updateText()
    {
        
    }
}
