using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingBlock : MonoBehaviour {

    public GameObject platform;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(Delay());
            
        }
    }
    IEnumerator Delay()
    {
        Debug.Log("Before Waiting 2 seconds");
        yield return new WaitForSeconds(2);
        Debug.Log("After Waiting 2 Seconds");
        Destroy(platform);
    }
}
