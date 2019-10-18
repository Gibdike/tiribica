using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoBehaviour1 : MonoBehaviour
{
    public GameObject porta;

    private void Start() {
        if(porta.GetComponent<BoxCollider2D>().isTrigger){
            porta.GetComponent<Animator>().SetBool("Aberta", false);
            porta.GetComponent<BoxCollider2D>().isTrigger = false;
        }else{
            porta.GetComponent<Animator>().SetBool("Aberta", true);
            porta.GetComponent<BoxCollider2D>().isTrigger = true;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        porta.GetComponent<Animator>().SetBool("Aberta", true);
        porta.GetComponent<BoxCollider2D>().isTrigger = true;
    }

}
