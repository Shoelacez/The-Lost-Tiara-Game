using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text coinsDisplay;
    public  int coinsPicked = 0;
    
    
    public void CountCoinsPicked()
    {
        coinsPicked++;
        coinsDisplay.text = coinsPicked.ToString();
    }
}
