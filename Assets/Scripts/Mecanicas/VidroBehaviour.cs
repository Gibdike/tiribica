using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidroBehaviour : MonoBehaviour
{
    public float frequencia;
    // Start is called before the first frame update
    public void FixedStart(){
        GetComponentInChildren<Animator>().SetBool("quebrando", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DestroyIsso(){
        GetComponentInChildren<Animator>().SetBool("quebrando", true);
        Destroy(gameObject, 1);
        
    }
}
