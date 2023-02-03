using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine;


public class Player : MonoBehaviour
{
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

    public void Kill(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
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
