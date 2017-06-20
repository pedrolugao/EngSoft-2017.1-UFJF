using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Objects : MonoBehaviour {

    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(-200f, 0f, 0f));
	}
	
	// Update is called once per frame
	void Update () {
        if (this.gameObject.transform.position.x <= -20)
        {
            Destroy(gameObject);
            Destroy(this);
        }
	}
}
