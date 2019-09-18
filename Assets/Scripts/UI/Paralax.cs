using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paralax : MonoBehaviour
{
    //Declarando imagem
    public RawImage paralax;
   
    // Update is called once per frame
    void Update()
    {
        //Controle de movimentacao de Paralax
        paralax.uvRect = new Rect(paralax.uvRect.x + 0.001f, paralax.uvRect.y, paralax.uvRect.width, paralax.uvRect.height);
    }
}
