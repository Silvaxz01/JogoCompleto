using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [Header("Config")]
    public Rigidbody2D rb;
    public int moveSpeed;
    private float direcao;
    private bool estaCorrendo;

    
    private UnityEngine.Vector3 facingRight;
    private UnityEngine.Vector3 facingLeft;

    public bool taNoChao;
    public Transform detectaChao;
    public LayerMask oQueEhChao;

    bool obj = false;

    public GameObject Objetivo;

    public GameObject arealixo;

    bool obj2 = false;

    public GameObject Lixo;
    public GameObject Lixo1;
    public GameObject Lixo2;
    public GameObject Lixo3;
    public GameObject Lixo4;

    public GameObject Pontuacao;
    public GameObject Pontuacao1;
    public GameObject Pontuacao2;
    public GameObject Pontuacao3;
    public GameObject Pontuacao4;
    public GameObject Pontuacao5;
    public GameObject Lixeira;
    public GameObject imagem;
    public GameObject Objetivo3;
    public GameObject Objetivo5;

    public GameObject limpador;
    public GameObject limpadorobj;

    public GameObject paredeInv;

    public GameObject aguasuja;
 

    public GameObject agualimpa;
    

    public GameObject lixoa;
    public GameObject lixob;
    public GameObject lixoc;
    public GameObject lixod;
    public GameObject lixoe;
    public GameObject lixof;
    public GameObject lixog;
    public GameObject lixoh;

    public GameObject lixoli;
    public GameObject lixolil;
    public GameObject lixolill;
    public GameObject lixollll;

    public GameObject dica;
    public GameObject dica2;
    public GameObject dica3;

    public GameObject dica4;
    public GameObject dica5;

    public GameObject obj55;



    public bool limp;

    bool limpo = false;

    Qlixo qlixo;

    public int qLixo = 0;

    public GameObject Objetivo2;
    public GameObject Objetivo4;

    public Animator animator;
    bool chave = false;
    public GameObject objChave;

    // Variáveis de som
    public AudioClip somAndando;
    public AudioClip somParando;
    public AudioClip somPulo; // Som do pulo
    private AudioSource audioSource;

    void Start()
    {
        
        facingRight = transform.localScale;
        facingLeft = transform.localScale;
        facingLeft.x = facingLeft.x * -1;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>(); // Inicializa o AudioSource
        Objetivo2.SetActive(false);
        Objetivo3.SetActive(false); 
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {   
            moveSpeed = 7;

        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = 5;
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            animator.SetBool("taCorrendo", true);
            if (!audioSource.isPlaying)
            {
                audioSource.clip = somAndando;
                audioSource.Play();
            }
        }
        else
        {
            animator.SetBool("taCorrendo", false);
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
                audioSource.clip = somParando;
                audioSource.Play();
            }
        }

        taNoChao = Physics2D.OverlapCircle(detectaChao.position, 0.2f, oQueEhChao);

        if (Input.GetButtonDown("Jump") && taNoChao == true)
        {
            rb.velocity = UnityEngine.Vector2.up * 12;
            animator.SetBool("taPulando", true);
            audioSource.clip = somPulo; // Define o som do pulo
            audioSource.Play(); // Toca o som do pulo
        }

        if (taNoChao && rb.velocity.y == 0)
        {
            animator.SetBool("taPulando", false);
        }

        direcao = Input.GetAxis("Horizontal"); //correr com o shift

        if (direcao < 0)
        {
            transform.localScale = facingRight;
        }
        if (direcao > 0)
        {
            transform.localScale = facingLeft;
        }

        rb.velocity = new UnityEngine.Vector2(direcao * moveSpeed, rb.velocity.y);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "porta" && chave)
        {
            SceneManager.LoadScene("Fora de casa");
        }
        if (col.gameObject.tag == "keys")
        {
            objChave.SetActive(false);
            chave = true;

            if (chave == true)
            {
                obj = true;
            }
            if (obj == true)
            {
                DestroyObject(Objetivo);
            }
            if (obj == true)
            {
                obj2 = true;
            }
            if (obj2 == true)
            {
                Objetivo2.SetActive(true);
            }
        }
            
        if (col.gameObject.tag == "Lixo")
        {
            Lixo.SetActive(false);
            qLixo = 1;
            Pontuacao.SetActive(false);
            Pontuacao1.SetActive(true);
        }
        if (col.gameObject.tag == "Lixo1")
        {
            Lixo1.SetActive(false);
            qLixo = 2;
            Pontuacao1.SetActive(false);
            Pontuacao2.SetActive(true);
        }
        if (col.gameObject.tag == "Lixo2")
        {
            Lixo2.SetActive(false);
            qLixo = 3;
            Pontuacao2.SetActive(false);
            Pontuacao3.SetActive(true);
        }
        if (col.gameObject.tag == "Lixo3")
        {
            Lixo3.SetActive(false);
            qLixo = 4;
            Pontuacao3.SetActive(false);
            Pontuacao4.SetActive(true);
        }
        if (col.gameObject.tag == "Lixo4")
        {
            Lixo4.SetActive(false);
            qLixo = 5;
            Pontuacao4.SetActive(false);
            Pontuacao5.SetActive(true);
        }
        if (col.gameObject.tag == "Lixeira")
        {
            Lixeira.SetActive(true);
            qLixo = 0;
            Pontuacao5.SetActive(false);
            Pontuacao.SetActive(true);
            imagem.SetActive(false);
            Objetivo2.SetActive(false); 
            Objetivo3.SetActive(true);
            lixoa.SetActive(true);
            lixob.SetActive(true);
            lixoc.SetActive(true);
            lixod.SetActive(true);
            lixoe.SetActive(false);
            lixof.SetActive(false);
            lixog.SetActive(false);
            lixoh.SetActive(false);
            lixoli.SetActive(true);
            lixolil.SetActive(true);
            lixolill.SetActive(true);
            lixollll.SetActive(true);


        }

        if(col.gameObject.tag == "foralixo")
        {
            DestroyObject(lixoa);
            DestroyObject(lixob);

            DestroyObject(lixoc);

            DestroyObject(lixod);

            lixoe.SetActive(true);
            lixof.SetActive(true);
            lixog.SetActive(true);
            lixoh.SetActive(true);
        }
        if (col.gameObject.tag == "obj5")
        {
            Objetivo3.SetActive(false);
            Objetivo4.SetActive(true);
            DestroyObject(obj55);

        }
        
        if (col.gameObject.tag == "dica")
        {
            dica.SetActive(true);
            dica2.SetActive(true);
            dica3.SetActive(true);
           
        }
        else
        {
            dica.SetActive(false);
            dica2.SetActive(false);
            dica3.SetActive(false);
      
        }
       
        



        if (col.gameObject.tag == "limpa")
        {
            limpador.SetActive(true);
            limpadorobj.SetActive(false);
            limpo = true;
            Objetivo4.SetActive(false);
            Objetivo5.SetActive(true);
            DestroyObject(paredeInv);
        }
        if (limpo = true)
        {
            
        }
       
        
    }
   
  

 
}
