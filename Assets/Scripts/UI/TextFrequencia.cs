using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFrequencia : MonoBehaviour
{
    public PlayerBehaviour player;
    public TiroBehaviour tiro;
    public PenduloBehaviour pendulo;
    public Text textFreq;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textFreq.text = (tiro.frequencia.ToString() + "Hz");
    }
}
