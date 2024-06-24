using UnityEngine;

public class Invader : MonoBehaviour
{                           //�p�����[�^�i��j
    [SerializeField]
    private float _speed;   //�ړ����x(0.003)
    [SerializeField]
    private float _destroyDelay;    //�e��������܂ł̎���(1)
    [SerializeField]
    private float _range; // �J�n���̈ʒu�𒆐S�Ƃ��鍶�E�̈ړ��͈�(12)
    [SerializeField]
    private float _missileInterval; // �~�T�C���̔��ˊԊu(1000)
    [SerializeField]
    private float _missilePower; // �~�T�C���ɉ�����́i�~�T�C���̑��x�j(10)

    private float _initX = 0F; // �J�n���� X ���W
    private float _direction = 0.002F; // �ړ�������ێ�����t�B�[���h
    private int _count;            //1�t���[�����Ƃ�1���Z����count

    // Start is called before the first frame update
    void Start()
    {
        _initX = transform.position.x; // _initX �����݂� X ���W�ōX�V
    }



    // Update is called once per frame
    private void Update()
    {

        var x = transform.position.x;
        var y = transform.position.y;
        var z = transform.position.z;
        _count += 1;             //1�t���[�����Ƃ�1���Z����count
        transform.position = new Vector3(x + _speed, y, z);

        if (x > (_initX + _range)) // x ���W��  _range����Ȃ畉�̕���
        {
            _direction = -_speed;
        }


        if (x < (_initX - _range)) // x ���W�� - _range ��菬�Ȃ琳�̕���
        {
            _direction = _speed;
        }
        transform.position = new Vector3(x + _direction, y, z);

        if (_count % _missileInterval == 0)         //_missileInterval�t���[�����Ƃ�
        {
            var imissile = GameObject.CreatePrimitive(PrimitiveType.Cylinder); // �~�T�C���Ƃ��ĉ~���𐶐�
            imissile.transform.localScale = new Vector3(0.1F, 0.1F, 0.1F); // �����T�C�Y���Ƒ傫���̂ŏ�����
            imissile.transform.position = new Vector3(x, y - 1, 0);

            var rigidbody = imissile.AddComponent<Rigidbody>();
            rigidbody.useGravity = false;  // �d�͂𖳌���

            rigidbody.velocity = new Vector3(0, -_missilePower, 0);// �~�T�C�����@�̂̈ʒu���牺�����ɔ�΂�����
            Destroy(imissile, _destroyDelay);  //_destroyDelay���imissile������
        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        var other = collision.gameObject;
        Destroy(other); //�e���G�ɓ����������A�e������
        Destroy(gameObject);    //�e�����g�ɓ����������A���g������
    }

}


