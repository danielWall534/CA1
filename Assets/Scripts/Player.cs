using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MovementSpeed = 10;
    public int health = 100;
    public GameObject BulletPrefab;
    public float BulletSpeed = 10;
    float horizontal;
    float vertical;

    float h, v;
    Rigidbody2D body;
    Vector2 velocity;
    Vector3 mousePosition;
    Vector3 direction;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //movement
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        velocity.x = horizontal * MovementSpeed;
        velocity.y = vertical * MovementSpeed;

        body.velocity = velocity;

        //rotation
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;

        direction = mousePosition - transform.position;
        direction.Normalize();
        transform.up = direction;
        
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(BulletPrefab, transform.position, Quaternion.identity);
        Rigidbody2D body = bullet.GetComponent<Rigidbody2D>();
        body.velocity = direction * BulletSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<Enemy>();
    }
}
