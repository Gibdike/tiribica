using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    //Velocidade de movimentaçao Horizontal do personagem
    public float velocidade;

    //Variavel de controle para movimentaçao de Salto
    public bool podePular;

    //Variavel que controla a Força/Altura que o personagem pula
    public float forcaPulo;

    //Variavel que armazenara o RigidBody do personagem
    private Rigidbody2D rb;

    //Variavel que linka o Tiro
    public GameObject tiro;
    // Start is called before the first frame update
    void Start()
    {
        //pegando o RigidBody do player
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movimentacao Direita/Esquerda do player
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * velocidade,rb.velocity.y);

        //Movimentaçao de pulo
        if(Input.GetKeyDown(KeyCode.W) && podePular)
        {
            //Adicionando Forca de pulo
            rb.AddForce(new Vector2( 0, forcaPulo));

            //Atualizando Variavel de controle e Pulo
            podePular = false;

            //Atualiando Variavel de controle de Animaçao
            GetComponent<Animator>().SetBool("Jumping", true);
        }

        //Controlando animaçoes do player
        if(rb.velocity.x != 0){

            //Personagem Andando
            GetComponent<Animator>().SetBool("Walking", true);
        }else{

            //Personagem Parado
            GetComponent<Animator>().SetBool("Walking", false);
        }

        //Girando o personagem em funcao da direçao
        if(rb.velocity.x < 0){

            //Personagem virado para a esquerda
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if(rb.velocity.x > 0){

            //Personagem virado para a direita
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        
        //Mecanica de tiro (Em andamento)
        if(Input.GetKey(KeyCode.Space)){

            //Ativando o alcance
            tiro.SetActive(true);
        }else{
            //Desativando o alcance
            tiro.SetActive(false);
        }
    }
    
    
}
