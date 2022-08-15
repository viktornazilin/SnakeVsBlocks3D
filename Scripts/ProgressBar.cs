using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Transform SnakeBlock;
    public Transform Finish;
    public Slider Slider;
    private float _startPos;

    private void Start()
    {
        _startPos = SnakeBlock.position.z;
    }
    private void Update()
    {
        float finish = Finish.position.z;
        float part = Mathf.InverseLerp(_startPos, finish, SnakeBlock.position.z);
        Slider.value = part;
    }
}
