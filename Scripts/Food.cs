using UnityEngine;

public class Food : MonoBehaviour
{
    public SnakeBlock SnakeBlock;
    public Player Player;
    private int _value;
    private AudioSource _sound; 
    void Awake()
    {
        _sound = GetComponent<AudioSource>();
        _value = 1;
    }
    private void OnTriggerEnter(Collider other)
    {
        _sound.Play();
        SnakeBlock.Grow(_value);
        Player.HP += _value;     
    }
    private void OnTriggerExit(Collider other)
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        Destroy(gameObject);
    }
}
