using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text scoreText;   // �X�R�A�\���p�e�L�X�g
    public Text timerText;   // �^�C�}�[�\���p�e�L�X�g
    public Text gameOverText; // �Q�[���I�[�o�[�\���p�e�L�X�g
    public float gameDuration = 60.0f; // �Q�[���̏����p�����ԁi�b�j
    public float itemTimeIncrease = 10.0f; // �A�C�e������������ۂɑ����鎞�ԁi�b�j

    private int score;
    private float timer;

    void Start()
    {
        score = 0;
        timer = gameDuration;
        UpdateScoreText();
        UpdateTimerText();
        gameOverText.enabled = false; // �Q�[���J�n����GameOverText���\���ɂ���

    }

    void Update()
    {
        // �^�C�}�[������������
        timer -= Time.deltaTime;
        UpdateTimerText();

        // �^�C�}�[���[���ɂȂ�����Q�[���I�[�o�[
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
            timerText.text = "Time: " + Mathf.Max(timer, 0).ToString("F2"); // �����_�ȉ�2���ŕ\��
        }
    }

    void GameOver()
    {
        // �Q�[���I�[�o�[����
        Debug.Log("Game Over!");
        gameOverText.text = "Game Over\nScore: " + score;
        gameOverText.enabled = true; // �Q�[���I�[�o�[�e�L�X�g��\������
    }
}