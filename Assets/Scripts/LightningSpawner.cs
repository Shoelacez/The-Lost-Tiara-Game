using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningSpawner : MonoBehaviour
{
    public GameObject lightningPreefab;
    float randomX;
    Vector2 spawnPosition;
    public float spawnRate=2f;
    float nextSpawn = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time+spawnRate;
            randomX=Random.Range(-43.3f, 41.8f);
            spawnPosition = new Vector2(randomX,transform.position.y);
            Instantiate(lightningPreefab,spawnPosition,Quaternion.identity);
        }
    }
}
