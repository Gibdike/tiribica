using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pernas : MonoBehaviour
{
    //O player que esse script deve alterar
    public GameObject player;
   
    //Se o pe estiver tocando algo
    private void OnTriggerEnter2D(Collider2D other){

        //Verificando se o pe esta encostado no chao
        if(other.gameObject.CompareTag("Chao") || other.gameObject.CompareTag("peso") ){

            //Atualizando a variavel de controle de Animaçao
            player.GetComponent<Animator>().SetBool("Jumping", false);

            //Atualizando a variavel de controle de Salto
            player.GetComponent<PlayerBehaviour>().podePular = true;
        }
    }
}
