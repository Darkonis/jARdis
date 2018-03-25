using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballscript : MonoBehaviour {
    public GameObject plane;
    public GameObject spawnPoint;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(plane.transform.position.y-20>transform.position.y)
        {
            
            transform.position = spawnPoint.transform.position;
        }
	}
}
