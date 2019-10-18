using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pernas : MonoBehaviour
{
    //O player que esse script deve alterar
    public GameObject player;
    public TiroBehaviour tiro;
   
    //Se o pe estiver tocando algo
    private void OnTriggerEnter2D(Collider2D other){

        //Verificando se o pe esta encostado no chao
        if(other.gameObject.CompareTag("Chao") || other.gameObject.CompareTag("peso") || other.gameObject.CompareTag("Caixa")){

            //Atualizando a variavel de controle de Animaçao
            player.GetComponent<Animator>().SetBool("Jumping", false);

            //Atualizando a variavel de controle de Salto
            player.GetComponent<PlayerBehaviour>().podePular = true;
        }
        
        }
    private void OnTriggerStay2D(Collider2D other) {
         if(other.gameObject.CompareTag("peso") && tiro.tipo == "Impulso"){
            if(Input.GetKey(KeyCode.Space)){
                if(player.transform.rotation.y != 0){
                    other.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(tiro.forcaImpulso, 0));
                }else{
                    other.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-tiro.forcaImpulso, 0));    
                }
            }
        }
    }
}

