﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float timer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        timer -= Time.deltaTime;

        if(timer < 0)
        {
            Destroy(gameObject);
        }
	}
}
