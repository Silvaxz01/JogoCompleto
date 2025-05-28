using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NPCDialog : MonoBehaviour
{
    public GameObject dialogBox;        // UI com o texto
    public TextMeshProUGUI dialogText;             // Componente Text da UI
    private int dialogIndex = 0;
    private bool playerInRange = false;

    private string[] falas = new string[]
    {
        "Oi, você conseguiu chegar aqui!! Parabéns!!!",
        "Agora pegue a mochila e ajude a replantar as árvores colocando as sementes."
    };

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            MostrarDialogo();
        }
    }

    void MostrarDialogo()
    {
        if (dialogIndex < falas.Length)
        {
            dialogText.text = falas[dialogIndex];
            dialogBox.SetActive(true);
            dialogIndex++;
        }
        else
        {
            dialogBox.SetActive(false);
            dialogIndex = 0;  // Reinicia se quiser repetir depois
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            playerInRange = false;
            dialogBox.SetActive(false);
            dialogIndex = 0;
        }
    }
}
