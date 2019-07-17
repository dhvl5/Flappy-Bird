using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(transform.position.x < -12.8)
        {
            transform.position = new Vector2(12.8f, 0);
        }
	}
}
