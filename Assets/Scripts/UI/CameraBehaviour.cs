using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    //O player que a camera deve enquadrar
    public Transform player;
    
    // Update is called once per frame
    void Update()
    {
        //Enquadrando camera
        transform.position = new Vector3(player.position.x, player.position.y, -10);
    }
}
