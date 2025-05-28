using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToScene : MonoBehaviour
{
    // Nome da cena para a qual o jogador será teletransportado
    public string sceneName;

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica se o objeto colidiu com o objeto marcado com a tag "TeleportZone"
        if (collision.gameObject.CompareTag("TeleportZone"))
        {
            // Teletransporta para a cena especificada
            SceneManager.LoadScene("MenuMorte");
        }
    }
}
