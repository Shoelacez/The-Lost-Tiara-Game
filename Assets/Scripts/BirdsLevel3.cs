using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BirdsLevel3 : MonoBehaviour
{
    private Rigidbody2D myBird;
    private float flySpeed = 4f;
    private bool unCaged = false;
    private bool isFacingRight = false;

    private int birdsToBeFreed = 3;
    public Text birdsLeftDisplay; 

    // Start is called before the first frame update
    void Start()
    {
        myBird = GetComponent<Rigidbody2D>();
        
    }


    private void FixedUpdate()
    {
        Fly();
    }

    private void Update()
    {
        if (birdsToBeFreed==0)
        {
            SceneManager.LoadScene("Level 4");
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            unCaged = true;
            birdsToBeFreed--;

            birdsLeftDisplay.text = birdsToBeFreed.ToString();
            //bug it reports multiple collisions with the same bird i want 
            //it to register a single collison only for each bird
            //that way players cant cheat by freeing the same bird 3 times to win that level

            Debug.Log(birdsToBeFreed+" birds left");
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
