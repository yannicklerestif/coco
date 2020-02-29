using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CocoScript : MonoBehaviour
{
    public static float DummyX = 0.0f;
    public static float DummyY = 0.0f;

    public float speed;
    public float vSpeed;
    public Rigidbody2D body;

    private Collider2D _collider2D;

    // Start is called before the first frame update
    void Start()
    {
        _collider2D = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        //gameObject.transform.position = new Vector2(transform.position.x + h * speed, transform.position.y + v * speed);

        float vitesseActuelle = body.velocity.y;
        float nouvelleVitesse = vitesseActuelle + v * vSpeed;
        body.velocity = new Vector2(h * speed, nouvelleVitesse);

        //Debug.unityLogger.Log($"vitesseActuelle: {vitesseActuelle} - nouvelleVitesse: {nouvelleVitesse}");
        //Physics2D.OverlapBoxAll()
        //Debug.unityLogger.Log($"x: {_collider2D.transform.position.x} - y: {_collider2D.transform.position.y} - bounds: {_collider2D.bounds}");
        //Vector2 groundColliderPoint = new Vector2(_collider2D.bounds.center.x - _collider2D.bounds.size.x / 2)
        DummyX = _collider2D.bounds.center.x - _collider2D.bounds.extents.x;
        DummyY = _collider2D.bounds.center.y - _collider2D.bounds.extents.y;
        Collider2D[] collider2Ds = Physics2D.OverlapBoxAll(new Vector2(DummyX, DummyY),
            new Vector2(_collider2D.bounds.extents.x, _collider2D.bounds.extents.y), 0);
        Debug.unityLogger.Log($"collider2Ds number: {collider2Ds.Length}");
    }
}
