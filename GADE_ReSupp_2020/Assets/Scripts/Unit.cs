using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Unit : MonoBehaviour {
    [SerializeField] protected int hp;
    [SerializeField] protected int maxHp;
    [SerializeField] protected int atk;
    [SerializeField] protected float spd;
    [SerializeField] protected int range;
    [SerializeField] protected int team;
    [SerializeField] protected Material[] mat;
    [SerializeField] protected Image healthBar;
    [SerializeField] protected int duration = 1;
    [SerializeField] protected float timer = 0;
    public int Hp
    {
        get
        {
            return hp;
        }
        set
        {
            hp = value;
        }
    }
    public int MaxHp
    {
        get
        {
            return maxHp;
        }
    }
    public int Atk
    {
        get
        {
            return atk;
        }
    }
    public float Spd
    {
        get
        {
            return spd; ;
        }
    }
    public int Range
    {
        get
        {
            return range;
        }
        set
        {
            range = value;
        }
    }
    public int Team
    {
        get
        {
            return team;
        }
    }
    public Material[] Mat
    {
        get
        {
            return mat;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
