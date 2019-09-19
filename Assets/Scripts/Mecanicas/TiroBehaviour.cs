using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroBehaviour : MonoBehaviour
{
    public float forca;

    public float frequencia;

    public Transform player;
    //Se o tiro pegar em algo
    private void OnTriggerEnter2D(Collider2D other) {
         //Mecanica de tiro (Em Andamento)
         
         if(other.gameObject.CompareTag("peso")){
            if(player.rotation.y != 0){
                if(other.gameObject.GetComponent<PenduloBehaviour>().frequencia == frequencia){
                    other.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-forca, 0));
                }
            }else{
                if(other.gameObject.GetComponent<PenduloBehaviour>().frequencia == frequencia){
                    other.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(forca, 0));
                }
            }
         }
    }
}
