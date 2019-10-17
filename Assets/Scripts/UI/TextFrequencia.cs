using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFrequencia : MonoBehaviour
{
    public TiroBehaviour tiro;
    public Text textFreq;
 
    // Update is called once per frame
    void Update()
    {
        textFreq.text = (tiro.frequencia.ToString() + "Hz");
    }
}
