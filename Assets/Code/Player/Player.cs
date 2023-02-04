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

    private bool can_grow = false;

    public void Evolve(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            can_grow = true;
            Debug.Log("comecou");
        }
        if(context.canceled)
        {
            can_grow = false;
            Debug.Log("temrinou");
        }
    }

    public void Kill1(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            Q.GetComponent<TriggerBehaviour>().KillEnemy();
            Debug.Log("Poe te nas putas minhoca de merda");
        }
        
    }

    public void Kill2(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            W.GetComponent<TriggerBehaviour>().KillEnemy();
            Debug.Log("Poe te nas putas minhoca de merda");
        }
        
    }

    public void Kill3(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            E.GetComponent<TriggerBehaviour>().KillEnemy();
            Debug.Log("Poe te nas putas minhoca de merda");
        }
    }

    public void Kill4(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            R.GetComponent<TriggerBehaviour>().KillEnemy();
            Debug.Log("Poe te nas putas minhoca de merda");
        }
    }

    private void FixedUpdate()
    {
        Slidin();
    }

    private void Slidin()
    {
        if(can_grow)
        {
            slider.value += progressBarSpeed;
        }
    }

}
