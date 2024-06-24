using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int scoreValue = 10;
    public GameController gameController;

    public object Score { get; internal set; }

    // Start is called before the first frame update
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0.2F, 0, Space.World);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameController.IncreaseTime(); // êßå¿éûä‘ÇëùÇ‚Ç∑
            gameController.AddScore(scoreValue);
            Destroy(gameObject);
        }
    }
}
