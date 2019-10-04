using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bunker : MonoBehaviour
{
    private bool tomandoDano;
    public float dps;

    public Animator porta;

    public PlayerBehaviour player;
    // Start is called before the first frame update
    void Start()
    {
        porta.SetBool("Aberta", true);
    }

    // Update is called once per frame
    void Update()
    {
        if(tomandoDano){
            player.vidas -= (dps*Time.deltaTime);      
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player")){
            tomandoDano = true;
            porta.SetBool("Aberta", false);
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player")){
            tomandoDano = false;
        }
    }
}
