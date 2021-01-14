using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public float delta = 10f;  // Amount to move left and right from the start point
    public float speed = 2.0f;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.player.enemy == "Enemy")
        {
            //collision.gameObject.SendMessage("ApplyDamage", 10);
            //TakeDamage(1);
        }
    }

    void Update()
    {
        Vector3 v = startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
     
    }

}

