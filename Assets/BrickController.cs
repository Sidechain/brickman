using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : MonoBehaviour
{

    Vector2 vector2;
    void Start()
    {
        
    }

public float speed = 10;
public Rigidbody2D rb;

public void Update()
{
    float h = Input.GetAxis("Horizontal");
    float v = Input.GetAxis("Vertical");

    Vector3 tempVect = new Vector3(h, v, 0);
    tempVect = tempVect.normalized * speed * Time.deltaTime;
    rb.MovePosition(rb.transform.position + tempVect);
}
}
