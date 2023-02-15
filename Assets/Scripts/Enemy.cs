using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float MovementSpeed = 10;
    public int Damage = 1;

    GameManager gameManager;
    Rigidbody2D body;
    Vector2 direction;
    GameObject player;


    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        GameObject.FindGameObjectsWithTag("GameController");
        GetComponent<GameManager>();
        GameObject.FindGameObjectsWithTag("Player");
    }


    void Update()
    {
        transform.up = direction;
        body.velocity = direction;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
