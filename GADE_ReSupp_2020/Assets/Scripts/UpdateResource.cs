using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateResource : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int resourceTotal = 0;
        GameObject[] resources = GameObject.FindGameObjectsWithTag("Resource");
        foreach (GameObject o in resources)
        {
            resourceTotal += o.GetComponent<Resource>().numResource;
        }
        Text resourceBox1 = GameObject.Find("ResourceText").GetComponent<Text>();
        resourceBox1.text = "Resources: " + resourceTotal;
	}
}
