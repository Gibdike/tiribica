using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroBehaviour : MonoBehaviour
{
    //Se o tiro pegar em algo
    private void OnTriggerEnter2D(Collider2D other) {
         Debug.Log("Encostou");
         //Mecanica de tiro (Em Andamento)
    }
}
