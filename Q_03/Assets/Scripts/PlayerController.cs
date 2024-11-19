using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [field: SerializeField]
    [field: Range(0, 100)]
    public int Hp { get; private set; }

    [SerializeField] AudioSource _audio;
    [SerializeField] GameObject player;

    private void Awake()
    {
        player.GetComponent<GameObject>();
        Init();
    }

    private void Init()
    {
        _audio = player.GetComponent<AudioSource>();
    }
    
    public void TakeHit(int damage)
    {
        Hp -= damage;

        if (Hp <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        _audio.Play();
        player.SetActive(false);
    }
}
