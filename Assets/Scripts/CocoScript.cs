using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CocoScript : MonoBehaviour
{
    private static readonly float GroundMargin = 0.01f;

    public float speed;
    public float vSpeed;
    public Rigidbody2D body;
    public EventManager eventManager;

    private Collider2D _collider2D;

    // Start is called before the first frame update
    void Start()
    {
        _collider2D = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var bottomX = _collider2D.bounds.center.x;
        var bottomY = _collider2D.bounds.center.y - _collider2D.bounds.extents.y;
        Collider2D[] collider2Ds = Physics2D.OverlapBoxAll(new Vector2(bottomX, bottomY),
            new Vector2(GroundMargin, -GroundMargin), 0);
        bool isGrounded = collider2Ds.Length == 2;

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        var hSpeed_ = h * speed;
        var vSpeed_ = body.velocity.y;

        if (isGrounded && v > 0)
        {
            vSpeed_ = v * vSpeed;
        }
        
        body.velocity = new Vector2(hSpeed_, vSpeed_);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "mort lave" || collision.gameObject.tag == "Monstre")
        {
            eventManager.OnPlayerDied();
        }
    }
}
