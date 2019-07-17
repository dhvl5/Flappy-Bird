using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public GameObject gameov;
    float speed = -2f;

	void Start ()
    {
        Debug.Log("start");
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = (new Vector2(speed,0));
    }
	
	void Update ()
    {
        if(gameov.GetComponent<GameControl>().isGameOver)
        {
            rb2d.velocity = Vector2.zero;
        }
    }
}
