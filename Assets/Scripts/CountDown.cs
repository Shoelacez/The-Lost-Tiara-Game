using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float timestart = 60f;
    public Text countDownDisplay;

    // Start is called before the first frame update
    void Start()
    {
        countDownDisplay.text = timestart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timestart -= Time.deltaTime;
        countDownDisplay.text = Mathf.Round(timestart).ToString();

    }
}
