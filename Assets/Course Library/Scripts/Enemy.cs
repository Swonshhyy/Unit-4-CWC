using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;   
    }

    // Update is called once per frame
    void Update()
    {
        enemyRb.AddForce(lookDirection * speed);   
    }
}
