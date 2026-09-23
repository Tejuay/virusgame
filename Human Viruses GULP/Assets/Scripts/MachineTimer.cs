using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MachineTimer : MonoBehaviour
{
    public float currentTimer = 0f;
    public float maxTimer = 10f;
    public float speed = 1f;

    public Slider timerSlider;
    public GameObject gameOverScreen;

    private int playerCount = 0;
    private bool gameOver = false;

    void Start()
    {
        gameOverScreen.SetActive(false);
    }

    void Update()
    {
        if (gameOver)
            return;

        if (playerCount > 0)
        {
            currentTimer += speed * playerCount * Time.deltaTime;
        }
        else
        {
            currentTimer -= speed * Time.deltaTime;
        }

        currentTimer = Mathf.Clamp(currentTimer, 0f, maxTimer);

        if (timerSlider != null)
            timerSlider.value = currentTimer / maxTimer;

        if (currentTimer <= 0f)
        {
            GameOver();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerCount++;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerCount--;
            playerCount = Mathf.Max(playerCount, 0);
        }
    }

    private void GameOver()
    {
        gameOver = true;
        Time.timeScale = 0;

        if (gameOverScreen != null)
            gameOverScreen.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
