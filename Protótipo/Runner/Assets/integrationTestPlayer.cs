using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class integrationTestPlayer : MonoBehaviour {

    public Rigidbody rb2;
    public int rot;
    // Use this for initialization
    void Start()
    {
        rb2 = GetComponent<Rigidbody>();
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {   
        rot = Mathf.Max((int)((Mathf.Abs(rb2.rotation.x) + Mathf.Abs(rb2.rotation.y) + Mathf.Abs(rb2.rotation.z))*10),rot);
        if (rb2.position.y <= 0.63){
            rb2.AddForce(new Vector3(0f, 400f, 0f));
        }
        

    }
}
