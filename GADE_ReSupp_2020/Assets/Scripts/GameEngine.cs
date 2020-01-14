using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEngine : MonoBehaviour {

    [SerializeField] GameObject[] options = new GameObject[2];
    [SerializeField] static int minX = -10;
    [SerializeField] static int maxX = 10;
    [SerializeField] static int minZ = -10;
    [SerializeField] static int maxZ = 10;
    [SerializeField] static int units = 6;

    // Use this for initialization
    void Start () {
		for (int i = 0; i < units; i++)
        {
            CreateUnit();
        }
	}
	
	void CreateUnit()
    {
        GameObject unit = Instantiate(options[Random.Range(0, 2)]);
        unit.transform.position = new Vector3(Random.Range(minX, maxX), 0, Random.Range(minZ, maxZ));
    }


}
