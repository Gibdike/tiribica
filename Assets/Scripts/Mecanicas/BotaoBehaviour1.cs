using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoBehaviour1 : MonoBehaviour
{
    public Animator porta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        porta.SetBool("Aberta", true);
    }

}
