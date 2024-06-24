using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text scoreText;   // スコア表示用テキスト
    public Text timerText;   // タイマー表示用テキスト
    public Text gameOverText; // ゲームオーバー表示用テキスト
    public float gameDuration = 60.0f; // ゲームの初期継続時間（秒）
    public float itemTimeIncrease = 10.0f; // アイテムを回収した際に増える時間（秒）

    private int score;
    private float timer;

    void Start()
    {
        score = 0;
        timer = gameDuration;
        UpdateScoreText();
        UpdateTimerText();
        gameOverText.enabled = false; // ゲーム開始時にGameOverTextを非表示にする

    }

    void Update()
    {
        // タイマーを減少させる
        timer -= Time.deltaTime;
        UpdateTimerText();

        // タイマーがゼロになったらゲームオーバー
        if (timer <= 0)
        {
            GameOver();
        }
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScoreText();
    }

    public void IncreaseTime()
    {
        timer += itemTimeIncrease;
        UpdateTimerText();
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    void UpdateTimerText()
    {
        if (timerText != null)
        {
            timerText.text = "Time: " + Mathf.Max(timer, 0).ToString("F2"); // 小数点以下2桁で表示
        }
    }

    void GameOver()
    {
        // ゲームオーバー処理
        Debug.Log("Game Over!");
        gameOverText.text = "Game Over\nScore: " + score;
        gameOverText.enabled = true; // ゲームオーバーテキストを表示する
    }
}