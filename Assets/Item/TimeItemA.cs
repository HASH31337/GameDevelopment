using UnityEngine;

public class TimeItemA : MonoBehaviour
{
    [SerializeField]
    private float _duration;

    /// <summary>
    /// ���Z���鎞�ԁi�b�P�ʁj
    /// </summary>
    public float Duration => _duration;
}