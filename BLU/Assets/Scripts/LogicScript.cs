using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public bool isGameOver = false;
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject youWinScreen;
    public Rigidbody2D turtleBody;
    public float winScore;

    void Update()
    {
        if (!isGameOver && playerScore >= winScore)
        {
            youWin();
        }
    }

    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        isGameOver = true;
        gameOverScreen.SetActive(true);

    }
    public void youWin()
    {
        isGameOver = true;
        youWinScreen.SetActive(true);
        turtleBody.linearVelocity = Vector2.zero;
        turtleBody.gravityScale = 0f;
        turtleBody.constraints = RigidbodyConstraints2D.FreezeAll;

    }

}
