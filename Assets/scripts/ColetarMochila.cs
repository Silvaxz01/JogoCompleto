using UnityEditor.Rendering;
using UnityEngine;

public class ColetarMochila : MonoBehaviour
{
    private GameObject mochilaProxima;
    public GameObject mochilaob;
    public GameObject sementecanva;
    

    void Update()
    {
        if (mochilaProxima != null && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(mochilaProxima);
            mochilaProxima = null;
            sementecanva.SetActive(true);
        }
           
        
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Mochila"))
        {
            mochilaProxima = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Mochila") && other.gameObject == mochilaProxima)
        {
            mochilaProxima = null;
        }
    }
}
