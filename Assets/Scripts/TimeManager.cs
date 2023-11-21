using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public TMP_Text timerText;  
    public static string timer;
    private float elapsedTime = 0f;  

    void Start()
    {
        StartCoroutine(UpdateTimerCoroutine());
    }

    IEnumerator UpdateTimerCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            elapsedTime += 1f;
            UpdateTimerText();
        }
    }

    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        string timerString = string.Format("{0:00}:{1:00}", minutes, seconds);
        timerText.text = timerString;
        timer = timerString;
    }

    public void ResetTimer()
    {
        elapsedTime = 0f;
        UpdateTimerText();  
    }

    public float GetElapsedTime()
    {
        return elapsedTime;
    }
}
