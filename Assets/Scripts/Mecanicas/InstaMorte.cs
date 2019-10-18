using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstaMorte : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        other.gameObject.GetComponent<PlayerBehaviour>().vidas = 0;
    }
}
