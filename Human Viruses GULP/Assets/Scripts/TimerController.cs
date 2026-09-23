using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public float startTime;
    private float timeLeft;

    public TMP_Text timerText;
    public TMP_Text winText;
    public Button startButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeLeft = startTime;
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft > 60)
            {
                //Mins + secs
                FormatToMinSec();
            }
            else
            {
                timerText.text = timeLeft.ToString("0.00");
            }
        }
        else
        {
            //Game win screen
            winText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
    

    public void ActivateGame()
    {
        Time.timeScale = 1;
        timeLeft = startTime;
        startButton.gameObject.SetActive(false);
        timerText.gameObject.SetActive(true);
    }

    void FormatToMinSec()
    {
        float mins = Mathf.FloorToInt(timeLeft / 60);
        float secs = Mathf.FloorToInt(timeLeft % 60);

        timerText.text = string.Format("{0:00}:{1:00}", mins, secs);
    }
}
