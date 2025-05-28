using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public RuntimeAnimatorController animatorComMochila; // arraste o Animator com mochila no Inspector
    private Animator animator;
    private bool temMochila = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Mochila") && !temMochila)
        {
            PegarMochila(col.gameObject);
        }
    }

    void PegarMochila(GameObject mochila)
    {
        temMochila = true;
        animator.runtimeAnimatorController = animatorComMochila;
        Destroy(mochila);
    }
}
