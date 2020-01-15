﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEngine : MonoBehaviour {
    [SerializeField] GameObject[] options = new GameObject[2];
    [SerializeField] static int MIN_X = -10;
    [SerializeField] static int MAX_X = 10;
    [SerializeField] static int MIN_Z = -10;
    [SerializeField] static int MAX_Z = 10;
    [SerializeField] static int UNITS = 8;
    // Use this for initialization
    void Start () {
		for (int i = 0; i < UNITS; i++)
        {
            CreateUnit();
        }
	}

    void CreateUnit()
    {
        GameObject unit = Instantiate(options[Random.Range(0, 2)]);
        unit.transform.position = new Vector3(Random.Range(MIN_X, MAX_X), 0, Random.Range(MIN_Z, MAX_Z));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
