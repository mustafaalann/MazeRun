using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowTimeInTheEnd : MonoBehaviour
{
     public TMP_Text timerText;  
    void Start()
    {
        string timerString = TimeManager.timer;
        string newText = "You have reached to the end of the maze in "+timerString;
        timerText.text = newText;
    }


}
