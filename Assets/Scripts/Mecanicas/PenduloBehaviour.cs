using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenduloBehaviour : MonoBehaviour
{
    public float frequencia;
    
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("botao")){
            Debug.Log("Apertou");
        }
    }
}
