using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour {

    public Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Toggle the Object's visibility each second.
    void Update()
    {
        // Find out whether current second is odd or even
        bool oddeven = Mathf.Floor(Time.time) % 2 == 0;


        // Enable renderer 
        rend.enabled = oddeven;
    }

}
