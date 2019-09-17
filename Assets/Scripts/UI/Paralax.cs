using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paralax : MonoBehaviour
{
    public RawImage paralax;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        paralax.uvRect = new Rect(paralax.uvRect.x + 0.001f, paralax.uvRect.y, paralax.uvRect.width, paralax.uvRect.height);
    }
}
