using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morte : MonoBehaviour
{
    public GameObject player;
    public GameObject respawn;
    public GameObject telaMorte;

    private void Start() {
        telaMorte.SetActive(false);
    }

    private void Update() {
        if (player.GetComponent<PlayerBehaviour>().vidas < 1){
            telaMorte.SetActive(true);      
        }
    }
    public void Respawn(){
        player.transform.position = respawn.transform.position;
        player.GetComponent<PlayerBehaviour>().vidas = 10;
        telaMorte.SetActive(false);
    }

    
}
