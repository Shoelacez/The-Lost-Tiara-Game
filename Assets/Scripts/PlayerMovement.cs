using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 11f;
    [SerializeField] private float jumpForce = 10f;
    private float movementX;
    private bool isGrounded=false;

    private Rigidbody2D myPlayer;

    // Start is called before the first frame update
    void Start()
    {
        myPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void FixedUpdate()
    {
        Jump();
    }

    void Move()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX, 0f, 0f)*moveSpeed*Time.deltaTime;
    }
    void Jump()
    {
        if(Input.GetMouseButtonDown(1) && isGrounded)
        {
            myPlayer.AddForce(new Vector2(0f,jumpForce),ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
       
    }
}
