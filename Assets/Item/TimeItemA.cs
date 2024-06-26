using UnityEngine;

public class TimeItemA : MonoBehaviour
{
    [SerializeField]
    private float _duration;

    /// <summary>
    /// 加算する時間（秒単位）
    /// </summary>
    public float Duration => _duration;
}