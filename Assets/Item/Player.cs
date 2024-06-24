using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Vector3 initialPosition; // �v���C���[�̏����ʒu

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        initialPosition = transform.position; // �v���C���[�̌��݂̈ʒu�������ʒu�Ƃ��Đݒ肷��
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
        // �v���C���[�̈ʒu�������ʒu�ɖ߂�
        transform.position = initialPosition;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
