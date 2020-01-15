using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RangedUnit : Unit {
    
	// Use this for initialization
	void Start () {
        hp = 10;
        maxHp = hp;
        atk = 2;
        range = 2;
        spd = 0.5f;
        team = Random.Range(1, 3);
        GetComponent<MeshRenderer>().material = mat[team - 1];
    }
}
