using UnityEngine;

public class ItemA : MonoBehaviour
{
    [SerializeField]
    private int _score;

    /// <summary>
    /// ���̃A�C�e���̃X�R�A�B
    /// </summary>
    public int Score => _score; // �ǂݎ���p�v���p�e�B
                                //public int Score { get { return _score; } } // ��L�Ɠ��`


    private void Update()
    {
        transform.Rotate(0, 0.2F, 0, Space.World);
    }
}