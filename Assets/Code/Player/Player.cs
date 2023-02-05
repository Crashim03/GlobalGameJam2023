using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
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
    public float health = 10f;

    public Animator regadorAnim;
    public ParticleSystem ps;

    private bool can_grow = false;
    private Animator anim;
    private int reset_counter = 0;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void Evolve(InputAction.CallbackContext context)
    {
        if(context.started)
        {
            regadorAnim.SetBool("Regar", true);
        }
        if (context.performed)
        {
            ps.Play();
            can_grow = true;
            Debug.Log("comecou");
        }
        if (context.canceled)
        {
            ps.Stop();
            can_grow = false;
            regadorAnim.SetBool("Regar", false);
            Debug.Log("temrinou");
        }
    }

    public void Kill1(InputAction.CallbackContext context)
    {
        if (context.performed && !can_grow)
        {
            if (anim.GetBool("Evolve") == true && anim.GetBool("Evolve1") == false)
            {
                anim.Play("Q_Attack_E1_Anim");
            }
            else if (anim.GetBool("Evolve1") == true)
            {
                anim.Play("Q_Attack_E2_Anim");
            }
            else
            {
                anim.Play("Q_Attack_Anim");
            }
            Q.GetComponent<TriggerBehaviour>().KillEnemy();
            Debug.Log("Poe te nas putas minhoca de merda");
        }

    }

    public void Kill2(InputAction.CallbackContext context)
    {
        if (context.performed && !can_grow)
        {
            if (anim.GetBool("Evolve") == true && anim.GetBool("Evolve1") == false)
            {
                anim.Play("W_Attack_E1_Anim");
            }
            else if (anim.GetBool("Evolve1") == true)
            {
                anim.Play("W_Attack_E2_Anim");
            }
            else
            {
                anim.Play("W_Attack_Anim");
            }
            W.GetComponent<TriggerBehaviour>().KillEnemy();
            Debug.Log("Poe te nas putas minhoca de merda");
        }

    }

    public void Kill3(InputAction.CallbackContext context)
    {
        if (context.performed && !can_grow)
        {
            if (anim.GetBool("Evolve") == true && anim.GetBool("Evolve1") == false)
            {
                anim.Play("E_Attack_E1_Anim");
            }
            else if (anim.GetBool("Evolve1") == true)
            {
                anim.Play("E_Attack_E2_Anim");
            }
            else
            {
                anim.Play("E_Attack_Anim");
            }
            E.GetComponent<TriggerBehaviour>().KillEnemy();
            Debug.Log("Poe te nas putas minhoca de merda");
        }
    }

    public void Kill4(InputAction.CallbackContext context)
    {
        if (context.performed && !can_grow)
        {
            if (anim.GetBool("Evolve") == true && anim.GetBool("Evolve1") == false)
            {
                anim.Play("R_Attack_E1_Anim");
            }
            else if (anim.GetBool("Evolve1") == true)
            {
                anim.Play("R_Attack_E2_Anim");
            }
            else
            {
                anim.Play("R_Attack_Anim");
            }
            R.GetComponent<TriggerBehaviour>().KillEnemy();
        }
    }

    private void FixedUpdate() {
        Slidin();
    }

    private void Update()
    {
        slider.value = health;
        if (health >= slider.maxValue)
        {
            if (reset_counter == 1)
            {
                anim.SetBool("Evolve1", true);
            }
            else
            {
                anim.SetBool("Evolve", true);
            }
            ResetSlider();

            GameObject.Find("Enemy Manager").GetComponent<EnemyManager>().NextLevel();
        }
        else if (health <= 0)
        {
            SceneManager.LoadScene("GameOverMenu");
        }
    }

    private void Slidin()
    {
        if (can_grow)
        {
            health += progressBarSpeed;
        }
    }

    private void ResetSlider()
    {
        reset_counter++;
        health = 10;
    }

}
