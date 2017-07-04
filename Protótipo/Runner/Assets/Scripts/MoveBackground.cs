using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour {
    public float speed = 0.1f;
    public Renderer rend;
	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
        float offset = Time.time * speed;
        rend.material.mainTextureOffset = new Vector2(0.0f , offset);
    }
}
