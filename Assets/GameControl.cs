using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

    public bool isGameOver = false;
    private int score = 0;
    
    public Text scoreText;
    public GameObject gameOverText;


	void Start ()
    {
        
    }
	
	void Update ()
    {
        if (isGameOver && Input.GetMouseButton(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void Score()
    {
        score++;
        scoreText.text = "" + score;
    }

    public void Die()
    {
        isGameOver = true;
        gameOverText.SetActive(true);
    }
}
