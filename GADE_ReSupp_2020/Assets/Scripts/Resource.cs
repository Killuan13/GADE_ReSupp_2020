﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour {
    [SerializeField] int resource;

    public int numResource { get => resource; }

    // Use this for initialization
    void Start () {
        resource = Random.Range(0, 101);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
