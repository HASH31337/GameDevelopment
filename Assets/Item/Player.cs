using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Vector3 initialPosition; // プレイヤーの初期位置

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        initialPosition = transform.position; // プレイヤーの現在の位置を初期位置として設定する
    }

    // Update is called once per frame
    void Update()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        _rigidbody.AddForce(h, 0, v);

       
        if (transform.position.y < -10.0f) 
        {
            ResetPlayerPosition();
        }

    }

    void ResetPlayerPosition()
    {
        // プレイヤーの位置を初期位置に戻す
        transform.position = initialPosition;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
