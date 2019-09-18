using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pernas : MonoBehaviour
{
    public GameObject player;
   
   private void OnCollisionEnter2D(Collision2D other) {
       if(other.gameObject.CompareTag("Chao")){
            player.GetComponent<Animator>().SetBool("Jumping", false);
            player.GetComponent<PlayerBehaviour>().podePular = true;
       }
   }
}
