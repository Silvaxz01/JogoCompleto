using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaDeCena : MonoBehaviour
{
    public string Park1; // nome exato da cena no projeto

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            SceneManager.LoadScene(Park1); // ou: LoadScene(1) se quiser por índice
        }
    }
}
