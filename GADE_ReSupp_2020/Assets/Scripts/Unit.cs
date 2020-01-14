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
		if (!IsInRange(GetClosestUnit()))
        {
            transform.position = Vector3.MoveTowards(transform.position, GetClosestUnit().transform.position, spd * Time.deltaTime);
        }
        healthBar.fillAmount = (float)hp / maxHp;
        timer += Time.deltaTime;
        if (timer >= duration)
        {
            hp--;
            timer = 0;
        }
	}

    protected bool IsInRange (GameObject enemy)
    {
        bool returnVal = false;

        if (Vector3.Distance(transform.position, enemy.transform.position) <= range)
        {
            return true;
        }
        else return false;
    }

    protected GameObject GetClosestUnit()
    {
        GameObject unit = null;
        GameObject[] units = null;
        switch (team)
        {
            case 1: GameObject.FindGameObjectsWithTag("team 2");
                break;
            case 2:
                GameObject.FindGameObjectsWithTag("team 1");
                break;
        }
        float distance = 9999;
        foreach (GameObject temp in units)
        {
            float tempDist = Vector3.Distance(transform.position, temp.transform.position);
            if (tempDist <= distance)
            {
                distance = tempDist;
                unit = temp;
            }
        }
        return unit;
    }
}
