using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform position;
    public Transform playerPosition;
    public GameObject Spawner;
    public float damage = 50f;
    public Animator anim;

    public float speed = 5f;

    private void Start()
    {
        Vector3 targ = playerPosition.position;
        targ.z = 0f;

        Vector3 objectPos = transform.position;
        targ.x = targ.x - objectPos.x;
        targ.y = targ.y - objectPos.y;

        float angle = Mathf.Atan2(targ.y, targ.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));

        rb.velocity = new Vector2(Mathf.Cos(position.rotation.eulerAngles.z * Mathf.Deg2Rad + Mathf.PI / 2),
                      Mathf.Sin(position.rotation.eulerAngles.z * Mathf.Deg2Rad + Mathf.PI / 2)) * speed;

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            GameObject.Find("Player").GetComponent<Player>().health -= damage * 2;
        }
    }

    private void OnDestroy()
    {
        Spawner.GetComponent<Spawner>().canSpawn = true;
    }
}
