using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Rigidbody2D player;
    public float speed;
    public Text score;

    private static int points = 0;
    private float movement;
    private int jumpCounter = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
        player.velocity = new Vector2(movement * speed, player.velocity.y);

        if (Input.GetKeyDown("space")) 
        {
            if (jumpCounter < 2)
            {
                player.velocity = Vector2.up * 10;
            }
            jumpCounter++;
            Debug.Log("jumped");
        };
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Floor"))
        {
            jumpCounter = 0;
            Debug.Log("Collision");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Covid"))
        {
            SceneManager.LoadScene(2);
        }

        if (collision.gameObject.tag == ("Vaccine"))
        {
            points++;
            score.text = points.ToString();
            Destroy(collision.gameObject);
        }

    }
}
