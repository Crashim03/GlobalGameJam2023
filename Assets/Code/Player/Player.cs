using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine;


public class Player : MonoBehaviour
{
    public GameObject Q;
    public GameObject W;
    public GameObject E;
    public GameObject R;
    public Slider slider;
    public float progressBarSpeed;
    public float health;

    private bool can_grow = false;
    private Animator anim;

    private void Awake() {
        anim = GetComponent<Animator>();
    }

    public void Evolve(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            can_grow = true;
            Debug.Log("comecou");
        }
        if (context.canceled)
        {
            can_grow = false;
            Debug.Log("temrinou");
        }
    }

    public void Kill1(InputAction.CallbackContext context)
    {
        if (context.performed && !can_grow)
        {
            anim.Play("Q_Attack_Anim");
            Q.GetComponent<TriggerBehaviour>().KillEnemy();
            Debug.Log("Poe te nas putas minhoca de merda");
        }

    }

    public void Kill2(InputAction.CallbackContext context)
    {
        if (context.performed && !can_grow)
        {
            anim.Play("W_Attack_Anim");
            W.GetComponent<TriggerBehaviour>().KillEnemy();
            Debug.Log("Poe te nas putas minhoca de merda");
        }

    }

    public void Kill3(InputAction.CallbackContext context)
    {
        if (context.performed && !can_grow)
        {
            anim.Play("E_Attack_Anim");
            E.GetComponent<TriggerBehaviour>().KillEnemy();
            Debug.Log("Poe te nas putas minhoca de merda");
        }
    }

    public void Kill4(InputAction.CallbackContext context)
    {
        if (context.performed && !can_grow)
        {
            anim.Play("R_Attack_Anim");
            R.GetComponent<TriggerBehaviour>().KillEnemy();
            Debug.Log("Poe te nas putas minhoca de merda");
        }
    }

    private void Update() {
        if(slider.value >= slider.maxValue)
        {
            anim.Play("Evolve_Idle_Anim");
        }
    }

    private void FixedUpdate()
    {
        Slidin();
        slider.value = health;
    }

    private void Slidin()
    {
        if (can_grow)
        {
            health += progressBarSpeed;
        }
    }

}
