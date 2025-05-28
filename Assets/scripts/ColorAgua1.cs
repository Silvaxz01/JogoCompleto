using System;
using System.Threading.Tasks;
using UnityEngine;

public class ColorAgua1 : MonoBehaviour
{
    public GameObject ativar;
    public GameObject desativar;

    private bool podeInteragir = false;


    void Update()
    {
        if (podeInteragir && Input.GetKeyDown(KeyCode.E))
        {
            if (ativar != null)
                ativar.SetActive(true);

            if (desativar != null)
                desativar.SetActive(false);
        }
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            podeInteragir = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            podeInteragir = false;
        }
    }
}