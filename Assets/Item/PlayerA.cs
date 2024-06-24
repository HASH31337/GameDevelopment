using UnityEngine;

public class PlayerA : MonoBehaviour
{
    [SerializeField]
    private float _gameTime = 10; // ゲーム実行時間（秒）

    private int _totalScore;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // 制限時間を超えたかどうか
        if (Time.time > _gameTime)
        {
            Debug.Log($"時間切れ: ゲームオーバー");
            _rigidbody.velocity = Vector3.zero;
            _rigidbody.angularVelocity = Vector3.zero;
            return;
        }

        // 落下判定
        if (transform.position.y < -10)
        {
            Debug.Log($"落下: ゲームオーバー");
            _rigidbody.velocity = Vector3.zero;
            _rigidbody.angularVelocity = Vector3.zero;
            transform.position = new Vector3(0, 1, 0); // 初期座標に戻す処理
            return;
        }

        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        _rigidbody.AddForce(h, 0, v);

        Debug.Log($"残り時間: {_gameTime - Time.time}");
    }

    private void OnTriggerEnter(Collider other)
    {
        var itemA = other.GetComponent<Item>();
        if (itemA) // 交差した相手がアイテムかどうか
        {
           // _totalScore += itemA.Score;
            Destroy(itemA.gameObject);
            Debug.Log($"Item: Score={itemA.Score}, Total={_totalScore}");
        }

        var timeItem = other.GetComponent<TimeItemA>();
        if (timeItem)
        {
            _gameTime += timeItem.Duration;
            Destroy(timeItem.gameObject);
            Debug.Log($"TimeItem: Duration={timeItem.Duration}, GameTime={_gameTime}");
        }
    }
}
















