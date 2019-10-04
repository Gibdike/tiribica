using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morte : MonoBehaviour
{
    public PlayerBehaviour player;
    private void Update() {
        if (player.vidas < 1){
            Destroy (gameObject);
        }
    }

    
}
