using UnityEngine;

public class PlayerA : MonoBehaviour
{
    [SerializeField]
    private float _gameTime = 10; // �Q�[�����s���ԁi�b�j

    private int _totalScore;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // �������Ԃ𒴂������ǂ���
        if (Time.time > _gameTime)
        {
            Debug.Log($"���Ԑ؂�: �Q�[���I�[�o�[");
            _rigidbody.velocity = Vector3.zero;
            _rigidbody.angularVelocity = Vector3.zero;
            return;
        }

        // ��������
        if (transform.position.y < -10)
        {
            Debug.Log($"����: �Q�[���I�[�o�[");
            _rigidbody.velocity = Vector3.zero;
            _rigidbody.angularVelocity = Vector3.zero;
            transform.position = new Vector3(0, 1, 0); // �������W�ɖ߂�����
            return;
        }

        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        _rigidbody.AddForce(h, 0, v);

        Debug.Log($"�c�莞��: {_gameTime - Time.time}");
    }

    private void OnTriggerEnter(Collider other)
    {
        var itemA = other.GetComponent<Item>();
        if (itemA) // �����������肪�A�C�e�����ǂ���
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
















