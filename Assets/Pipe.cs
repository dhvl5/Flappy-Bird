using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    

	void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(transform.position.x < -3.65f)
        {
            transform.position = new Vector3(12.35f, Random.Range(2.68f, -2.74f));
        }
	}
}
