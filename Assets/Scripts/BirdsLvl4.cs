using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdsLvl4 : MonoBehaviour
{
    private Rigidbody2D myBird;
    private float flySpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        myBird = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Fly();
    }
    void Fly()
    {
            myBird.velocity = new Vector2(-flySpeed, myBird.velocity.y);
    }
}
