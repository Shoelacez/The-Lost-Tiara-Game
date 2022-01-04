using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class King : MonoBehaviour
{
    private Rigidbody2D myKing;
    public float runSpeed=3f;
    private bool shouldRun = false;



    // Start is called before the first frame update
    void Start()
    {
        myKing = GetComponent<Rigidbody2D>();
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(shouldRun)
        {
            Run();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bird"))
        {
            Debug.Log(other.gameObject+" is colliding with "+this.gameObject);
            shouldRun = true;
        }
    }
    void Run()
    {
        myKing.velocity = new Vector2(-runSpeed,myKing.velocity.y);
     
    }
}
