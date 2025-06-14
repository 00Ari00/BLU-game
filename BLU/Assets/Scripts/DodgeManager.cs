using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DodgeManager : MonoBehaviour
{
    public static DodgeManager Instance;

    public float surviveTime = 15f; // seconds to win
    private float timer = 0f;

    public int hitCount = 0;
    public int maxHits = 5;

    public bool isGameOver = false;
    public TextMeshProUGUI TimerText;
    public TextMeshProUGUI HitText;
    public TextMeshProUGUI EndText; // for "Game Over" or "You Win"

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        UpdateHits(0);
        EndText.gameObject.SetActive(false);
    }

    void Update()
    {
        if (isGameOver) {
            if (Input.GetKeyDown(KeyCode.R))
            {
                RestartGame();
            }
            return;
        }

        // Count survival time
        timer += Time.deltaTime;

        float timeLeft = Mathf.Max(0f, surviveTime - timer);
        TimerText.text = "Time: " + timeLeft.ToString("F1") + "s";

        if (timer >= surviveTime)
        {
            WinGame();
        }
    }

    public void RegisterHit()
    {
        hitCount++;
        UpdateHits(hitCount);

        if (hitCount >= maxHits)
        {
            GameOver();
        }
    }

    void UpdateHits(int h)
    {
        HitText.text = "Hits: " + h + "/" + maxHits;
    }

    void WinGame()
    {
        isGameOver = true;
        EndText.text = "YOU WIN!";
        EndText.gameObject.SetActive(true);
    }

    void GameOver()
    {
        isGameOver = true;
        EndText.text = "GAME OVER! Press R to Restart";
        EndText.gameObject.SetActive(true);
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
