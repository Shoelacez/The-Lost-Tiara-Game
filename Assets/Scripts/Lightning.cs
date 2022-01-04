using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lightning : MonoBehaviour
{
    private Rigidbody2D myLightning;
    public float speed = 2f;
    Health healthScript;

    // Start is called before the first frame update
    void Start()
    {
        myLightning = GetComponent<Rigidbody2D>();
        healthScript = FindObjectOfType<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        myLightning.velocity = new Vector2(speed,myLightning.velocity.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            healthScript.TakeDamage();
            Destroy(this.gameObject);
        }
    }
}
