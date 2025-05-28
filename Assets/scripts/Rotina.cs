using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Rotina : MonoBehaviour
{
    public string carregarCasa;
    private string[] textos = new string[3];
    private GameObject texto;
    private int cont = 0;
    public float delay = 0.1f; // Delay entre cada letra
    public float pauseAfterText = 2f; // Tempo de espera após mostrar todo o texto

    void Start()
    {
        // Inicializa os textos
        textos[0] = "Eu não consigo parar de pensar no parque...";
        textos[1] = "As memórias são muito fortes...";
        textos[2] = "Eu tenho que salvar o parque...";

        // Busca o GameObject para o texto
        texto = GameObject.Find("texto");
        if (texto == null)
        {
            Debug.LogError("GameObject 'texto' não encontrado!");
            return; // Não continua se 'texto' não for encontrado
        }

        // Verifica se o componente Text existe
        Text textoComponent = texto.GetComponent<Text>();
        if (textoComponent == null)
        {
            Debug.LogError("Componente Text não encontrado em 'texto'!");
            return; // Não continua se o componente Text não for encontrado
        }

        // Inicia a Coroutine
        StartCoroutine(RotinaCoroutine());
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
             SceneManager.LoadScene(carregarCasa);
        }
    }

    private IEnumerator RotinaCoroutine()
    {
        while (cont < textos.Length)
        {
            // Escreve o texto letra por letra
            yield return StartCoroutine(EscreverTexto(textos[cont]));

            // Espera um pouco antes de mostrar o próximo texto
            yield return new WaitForSeconds(pauseAfterText);
            cont++;
        }

        // Carrega a nova cena
        SceneManager.LoadScene("Jogo");
    }

    private IEnumerator EscreverTexto(string textoCompleto)
    {
        Text textoComponent = texto.GetComponent<Text>();
        textoComponent.text = ""; // Limpa o texto atual

        foreach (char letra in textoCompleto)
        {
            textoComponent.text += letra; // Adiciona a letra
            yield return new WaitForSeconds(delay); // Espera antes de adicionar a próxima letra
        }
    }
}
