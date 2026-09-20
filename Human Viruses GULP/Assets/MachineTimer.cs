using UnityEngine;
using UnityEngine.UI;

public class MachineTimer : MonoBehaviour
{
    public float currentTimer = 0f;
    public float maxTimer = 10f;
    public float speed = 1f;

    public Slider timerSlider;

    private bool playerInside = false;

    void Update()
    {
        if (playerInside)
            currentTimer += speed * Time.deltaTime;
        else
            currentTimer -= speed * Time.deltaTime;

        currentTimer = Mathf.Clamp(currentTimer, 0f, maxTimer);

        if (timerSlider != null)
            timerSlider.value = currentTimer / maxTimer;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            playerInside = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            playerInside = false;
    }
}
