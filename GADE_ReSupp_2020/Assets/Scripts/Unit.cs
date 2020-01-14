using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour {
    [SerializeField] protected int hp;
    [SerializeField] protected int maxHp;
    [SerializeField] protected int atk;
    [SerializeField] protected float spd;
    [SerializeField] protected int range;
    [SerializeField] protected int team;
    [SerializeField] protected Material[] mat;

    public int Hp { get => hp; set => hp = value; }
    public int MaxHp { get => maxHp; }
    public int Atk { get => atk; }
    public float Spd { get => spd; }
    public int Range { get => range; set => range = value; }
    public int Team { get => team; }
    public Material[] Mat { get => mat; }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
