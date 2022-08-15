using System.Collections;
using UnityEngine;
using TMPro;

public class Obstacle : MonoBehaviour
{
    private int basicHealth;
    private int maxHealth;
    public SnakeBlock SnakeBlock;
    public Player Player;
    private readonly float colorChanger = 0.04f;
    public TMP_Text _text;
    private ParticleSystem _particleSystem;
    void Awake()
    {
        basicHealth = Random.Range(1, 11);
        maxHealth = basicHealth;
        gameObject.GetComponent<Renderer>().material.SetFloat("Power", basicHealth * colorChanger);
        _text.text = basicHealth.ToString();
        _particleSystem = GetComponent<ParticleSystem>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(Crash());
    }

    IEnumerator Crash()
    {
        while (basicHealth > 0 && Player.HP > 1)
        {
            yield return new WaitForSeconds(0.1f);
            _particleSystem.Play();
            basicHealth--;
            Player.HP--;
            SnakeBlock.Shrink();
            _text.text = basicHealth.ToString();
        }
        if (Player.HP >= 1 && basicHealth == 0) Destroy(gameObject);
        else Player.GameLogic.OnDeath();        
    }
    private void OnCollisionExit(Collision collision)
    {
        StopAllCoroutines();
    }
}
