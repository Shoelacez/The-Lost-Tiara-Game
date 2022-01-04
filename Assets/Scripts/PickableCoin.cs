using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickableCoin : MonoBehaviour
{
    Score scoreScript;
    private void Start()
    {
        scoreScript = FindObjectOfType<Score>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            scoreScript.CountCoinsPicked();
            Destroy(gameObject);
        }
    }
}
