using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBehaviour : MonoBehaviour
{
    public bool pressed = false;
    public Animator anim;

    private bool can_kill = false;
    private GameObject enemy;
    public AudioSource SoundEffect;

    private void Update()
    {
        Debug.Log(pressed);
        anim.SetBool("Pressed", pressed);
    }

    public void KillEnemy()
    {
        if (can_kill)
        {
            SoundEffect.Play();
            Destroy(enemy);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        can_kill = true;
        enemy = other.gameObject;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        can_kill = false;
    }
}
