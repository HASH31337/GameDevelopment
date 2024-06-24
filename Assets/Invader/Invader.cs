using UnityEngine;

public class Invader : MonoBehaviour
{                           //パラメータ（例）
    [SerializeField]
    private float _speed;   //移動速度(0.003)
    [SerializeField]
    private float _destroyDelay;    //弾が消えるまでの時間(1)
    [SerializeField]
    private float _range; // 開始時の位置を中心とする左右の移動範囲(12)
    [SerializeField]
    private float _missileInterval; // ミサイルの発射間隔(1000)
    [SerializeField]
    private float _missilePower; // ミサイルに加える力（ミサイルの速度）(10)

    private float _initX = 0F; // 開始時の X 座標
    private float _direction = 0.002F; // 移動方向を保持するフィールド
    private int _count;            //1フレームごとに1加算するcount

    // Start is called before the first frame update
    void Start()
    {
        _initX = transform.position.x; // _initX を現在の X 座標で更新
    }



    // Update is called once per frame
    private void Update()
    {

        var x = transform.position.x;
        var y = transform.position.y;
        var z = transform.position.z;
        _count += 1;             //1フレームごとに1加算するcount
        transform.position = new Vector3(x + _speed, y, z);

        if (x > (_initX + _range)) // x 座標が  _rangeより大なら負の方向
        {
            _direction = -_speed;
        }


        if (x < (_initX - _range)) // x 座標が - _range より小なら正の方向
        {
            _direction = _speed;
        }
        transform.position = new Vector3(x + _direction, y, z);

        if (_count % _missileInterval == 0)         //_missileIntervalフレームごとに
        {
            var imissile = GameObject.CreatePrimitive(PrimitiveType.Cylinder); // ミサイルとして円柱を生成
            imissile.transform.localScale = new Vector3(0.1F, 0.1F, 0.1F); // 初期サイズだと大きいので小さく
            imissile.transform.position = new Vector3(x, y - 1, 0);

            var rigidbody = imissile.AddComponent<Rigidbody>();
            rigidbody.useGravity = false;  // 重力を無効に

            rigidbody.velocity = new Vector3(0, -_missilePower, 0);// ミサイルを機体の位置から下方向に飛ばす処理
            Destroy(imissile, _destroyDelay);  //_destroyDelay後にimissileを消滅
        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        var other = collision.gameObject;
        Destroy(other); //弾が敵に当たった時、弾を消滅
        Destroy(gameObject);    //弾が自身に当たった時、自身を消滅
    }

}


