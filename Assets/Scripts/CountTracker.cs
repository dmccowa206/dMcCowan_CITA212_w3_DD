using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountTracker : MonoBehaviour
{
    public static int packNum = 0;
    public static bool victory = false;
    public TextMeshProUGUI packCount;
    public TextMeshProUGUI victoryText;

    void Update()
    {
        if (!victory)
        {
            packCount.text = "Packages Remaining: " + (3- packNum);
        }
        else{
            packCount.text = "";
            victoryText.text = "Mission Complete!";
        }
    }
}
