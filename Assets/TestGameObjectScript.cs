using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGameObjectScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector2(CocoScript.DummyX, CocoScript.DummyY);
    }
}
