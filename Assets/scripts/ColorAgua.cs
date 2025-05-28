using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class InteracaoComTecla : MonoBehaviour
{
    public GameObject ativar;
    public GameObject desativar;
    public GameObject sabao;
    public GameObject deter;
    public GameObject objetivocuzin;

    public GameObject objetivofinal;

    private bool podeInteragir = false;
    private bool interagindo = false;
    public bool receba = false;

    void Update()
    {
        if (podeInteragir && !interagindo && Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(ExecutarInteracaoComDelay());
        }
    }

    IEnumerator ExecutarInteracaoComDelay()
    {
        interagindo = true;

        yield return new WaitForSeconds(0.8f); // Delay de 3 segundos

        if (ativar != null)
            ativar.SetActive(true);

        if (desativar != null)
            desativar.SetActive(false);

        interagindo = false; 

        if(desativar == false)
        {
            receba = true;
        }
        if (receba = true)
        {
            DestroyObject(deter);
            DestroyObject(objetivocuzin);
            objetivofinal.SetActive(true);
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