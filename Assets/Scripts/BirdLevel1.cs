using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BirdLevel1 : MonoBehaviour
{
    private Rigidbody2D myBird;
    private float flySpeed = 2f;
    private bool unCaged = false;
    private bool isFacingRight = false;


    // Start is called before the first frame update
    void Start()
    {
        myBird = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        Fly();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            unCaged = true;
        }
    }
    void Fly()
    {
        if (unCaged && isFacingRight)
        {
            myBird.velocity = new Vector2(flySpeed, myBird.velocity.y);
        }
        else if (unCaged)
        {
            myBird.velocity = new Vector2(-flySpeed, myBird.velocity.y);
        }

    }

}
