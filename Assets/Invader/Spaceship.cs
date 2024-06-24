/*
using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        var x = transform.position.x;


        if (Input.GetKey(KeyCode.A)) // Aキーを押している
        {
            transform.position = new Vector3(x - 0.05F, 0, 0);
        }
        if (Input.GetKey(KeyCode.D)) // Dキーを押している
        {
            transform.position = new Vector3(x + 0.05F, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ミサイル発射処理
        }

    }
}
*/
using UnityEngine;

namespace Sample.Invaders
{




    public class Spaceship : MonoBehaviour
    {                           //パラメータ（例）
        [SerializeField]
        private float _speed;   //移動速度(0.01)
        [SerializeField]
        private float _destroyDelay;    //弾が消えるまでの時間(1)


        void Update()
        {
            var x = transform.position.x;
            var y = transform.position.y;
            var z = transform.position.z;




            if (Input.GetKey(KeyCode.LeftArrow)) // 左矢印キーを押している
            {
                transform.position = new Vector3(x - _speed, y, z);
            }
            if (Input.GetKey(KeyCode.RightArrow)) // 右矢印キーを押している
            {
                transform.position = new Vector3(x + _speed, y, z);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {

                var missile = GameObject.CreatePrimitive(PrimitiveType.Cylinder); // ミサイルとして円柱を生成
                missile.transform.localScale = new Vector3(0.1F, 0.1F, 0.1F); // 初期サイズだと大きいので小さく
                missile.transform.position = new Vector3(x, y + 1, z);

                var rigidbody = missile.AddComponent<Rigidbody>();
                rigidbody.useGravity = false;  // 重力を無効に

                rigidbody.velocity = new Vector3(0, 10, 0);// ミサイルを機体の位置から上方向に飛ばす処理
                Destroy(missile, _destroyDelay);  //_destroyDelay後にmissileを消滅
            }

        }
        private void OnCollisionEnter(Collision collision)
        {
            var other = collision.gameObject;
            Destroy(other);  //弾が敵に当たった時、弾を消滅
            Destroy(gameObject);    //弾が自機に当たった時、自機を消滅
        }
      
    }

}
