using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManager : MonoBehaviour
{
	[SerializeField] private string nomeDoLevelDeJogo;
	[SerializeField] private GameObject painelMenuInicial;
	[SerializeField] private GameObject painelOpcoes;

	public void Jogar()
	{
        SceneManager.LoadScene("Cutscene");

	}
	public void Voltar()
	{
		SceneManager.LoadScene("Park");
	}
    public void VoltarInicio()
    {
        SceneManager.LoadScene("Menu Principal");
    }

    public void AbrirOpcoes()
	{
		
		painelOpcoes.SetActive(true);
	}

	public void FecharOpcoes()
	{
		painelOpcoes.SetActive(false);
		painelMenuInicial.SetActive(true);


	}

	public void SairJogo()
	{
		Application.Quit(); 

	}
}
	