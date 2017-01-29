using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallOffRespawn : MonoBehaviour {

    public float threshold;

	// Use this for initialization
	void Start () {
        
		
	}
	
    void Update()
    {
        if (transform.position.y < threshold)
            transform.position = new Vector3(0, 0, 0);
    }
}

