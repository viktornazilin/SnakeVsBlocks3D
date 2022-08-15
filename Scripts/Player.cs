using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public GameLogic GameLogic;
    public int HP = 10;
    public TMP_Text Lives;
    public SnakeBlock SnakeBlock; 
    private void Start()
    {
        for (int i = 1; i < HP; i++) SnakeBlock.Grow(1);
    }
    void Update()
    {
        Lives.text = HP.ToString();
        if (HP <= 0) GameLogic.OnDeath();
    }
}
