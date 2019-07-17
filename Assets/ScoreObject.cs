using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreObject : MonoBehaviour
{

    public GameObject scores;

    void Update()
    {
        if (transform.position.x < -9.85)
        {
            transform.position = new Vector2(12.8f, Random.Range(2.68f, -2.74f));
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Playerscript>() != null)
        {
            scores.GetComponent<GameControl>().Score();
        }
    }
}
