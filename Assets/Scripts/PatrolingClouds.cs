using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolingClouds : MonoBehaviour
{
    const string LEFT = "left";
    const string RIGHT = "right";

    public Transform obstacleCheck;
    public float baseCastDist;
    string facingdirection;

    float speed = 1f;
    private Rigidbody2D myCloud;

    Vector3 baseScale;

    // Start is called before the first frame update
    void Start()
    {
        baseScale = transform.localScale;
        facingdirection = RIGHT;
        myCloud = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float velX = speed;

        if(facingdirection==LEFT)
        {
            velX = -speed;
        }
        myCloud.velocity = new Vector2(velX,myCloud.velocity.y);

        if(isHittingObstacle())
        {
            if (facingdirection == LEFT)
            {
                ChangeFacingDirection(RIGHT);
            }
            else
            {
                ChangeFacingDirection(LEFT);
            }
        }
    }

    void ChangeFacingDirection(string newDirection)
    {
        Vector3 newScale = baseScale;

        if(newDirection == LEFT)
        {
            newScale.x = -baseScale.x;
        }
        else
        {
            newScale.x = baseScale.x;
        }

        transform.localScale = newScale;

        facingdirection = newDirection;
    }
    bool isHittingObstacle()
    {
        bool val = false;

        float castDist = baseCastDist;

        if(facingdirection ==LEFT)
        {
            castDist = -baseCastDist;
        }

        Vector3 targetPos = obstacleCheck.position;
        targetPos.x += castDist;

        if(Physics2D.Linecast(obstacleCheck.position,targetPos,1 << LayerMask.NameToLayer("Terrain")))
        {
            val = true;
        }
        else
        {
            val = false;
        }

        return val;
    }
}
