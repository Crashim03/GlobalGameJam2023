using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform position;

    public float speed = 5f;

    private void Start()
    {
        Debug.Log(position.rotation.eulerAngles.z);
        rb.velocity = new Vector2(Mathf.Cos(position.rotation.eulerAngles.z * Mathf.Deg2Rad + Mathf.PI / 2),
                      Mathf.Sin(position.rotation.eulerAngles.z * Mathf.Deg2Rad + Mathf.PI / 2)) * speed;

    }
}
