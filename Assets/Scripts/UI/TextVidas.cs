using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextVidas : MonoBehaviour
{
    public PlayerBehaviour player;
    public Text txtVidas;

    // Update is called once per frame
    void Update()
    {
        txtVidas.text = ((int)player.vidas).ToString(); 
    }
}
