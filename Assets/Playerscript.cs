using UnityEngine;

public class Playerscript : MonoBehaviour
{
    public float upForce = 200f;
    private Rigidbody2D rb2d;
    public bool isDead = false;
    public GameObject gamecont;

    void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	void Update ()
    {
		if(Input.GetKeyDown("j") || Input.GetMouseButtonDown(0))
        {
            if(isDead) { return; }
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(new Vector2(0, upForce));
        }
	}

    void OnCollisionEnter2D(Collision2D colobj)
    {
        isDead = true;
        rb2d.velocity = Vector2.zero;
        gamecont.GetComponent<GameControl>().Die();
    }
}
