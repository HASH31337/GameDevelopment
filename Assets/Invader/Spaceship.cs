/*
using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        var x = transform.position.x;


        if (Input.GetKey(KeyCode.A)) // A�L�[�������Ă���
        {
            transform.position = new Vector3(x - 0.05F, 0, 0);
        }
        if (Input.GetKey(KeyCode.D)) // D�L�[�������Ă���
        {
            transform.position = new Vector3(x + 0.05F, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // �~�T�C�����ˏ���
        }

    }
}
*/
using UnityEngine;

namespace Sample.Invaders
{




    public class Spaceship : MonoBehaviour
    {                           //�p�����[�^�i��j
        [SerializeField]
        private float _speed;   //�ړ����x(0.01)
        [SerializeField]
        private float _destroyDelay;    //�e��������܂ł̎���(1)


        void Update()
        {
            var x = transform.position.x;
            var y = transform.position.y;
            var z = transform.position.z;




            if (Input.GetKey(KeyCode.LeftArrow)) // �����L�[�������Ă���
            {
                transform.position = new Vector3(x - _speed, y, z);
            }
            if (Input.GetKey(KeyCode.RightArrow)) // �E���L�[�������Ă���
            {
                transform.position = new Vector3(x + _speed, y, z);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {

                var missile = GameObject.CreatePrimitive(PrimitiveType.Cylinder); // �~�T�C���Ƃ��ĉ~���𐶐�
                missile.transform.localScale = new Vector3(0.1F, 0.1F, 0.1F); // �����T�C�Y���Ƒ傫���̂ŏ�����
                missile.transform.position = new Vector3(x, y + 1, z);

                var rigidbody = missile.AddComponent<Rigidbody>();
                rigidbody.useGravity = false;  // �d�͂𖳌���

                rigidbody.velocity = new Vector3(0, 10, 0);// �~�T�C�����@�̂̈ʒu���������ɔ�΂�����
                Destroy(missile, _destroyDelay);  //_destroyDelay���missile������
            }

        }
        private void OnCollisionEnter(Collision collision)
        {
            var other = collision.gameObject;
            Destroy(other);  //�e���G�ɓ����������A�e������
            Destroy(gameObject);    //�e�����@�ɓ����������A���@������
        }
      
    }

}
