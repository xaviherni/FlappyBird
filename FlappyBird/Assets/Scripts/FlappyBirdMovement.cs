using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBirdMovement : MonoBehaviour
{

    private Rigidbody2D rb;

    [SerializeField] private float flapforce = 7;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * flapforce, ForceMode2D.Impulse);
        }
    }



}
