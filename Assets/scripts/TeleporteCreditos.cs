using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportCreditos: MonoBehaviour
{
    // Nome da cena para a qual o jogador ser� teletransportado
    public string sceneName;

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica se o objeto colidiu com o objeto marcado com a tag "TeleportZone"
        if (collision.gameObject.CompareTag("Tele"))
        {
            // Teletransporta para a cena especificada
            SceneManager.LoadScene("Parvore");
        }
    }
}
