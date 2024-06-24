using UnityEngine;

public class ItemA : MonoBehaviour
{
    [SerializeField]
    private int _score;

    /// <summary>
    /// このアイテムのスコア。
    /// </summary>
    public int Score => _score; // 読み取り専用プロパティ
                                //public int Score { get { return _score; } } // 上記と同義


    private void Update()
    {
        transform.Rotate(0, 0.2F, 0, Space.World);
    }
}