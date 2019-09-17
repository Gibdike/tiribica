using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    public float velocidade;
    private Rigidbody2D rb;
    public bool podePular;
    public float forcaPulo;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * velocidade,rb.velocity.y);
        if(rb.velocity.x != 0){
            GetComponent<Animator>().SetBool("Walking", true);
        }else{
            GetComponent<Animator>().SetBool("Walking", false);
        }
        if(rb.velocity.x < 0){
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if(rb.velocity.x > 0){
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if(Input.GetKeyDown(KeyCode.W) && podePular)
        {
            rb.AddForce(new Vector2( 0, forcaPulo));
            podePular = false;
            GetComponent<Animator>().SetBool("Jumping", true);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Chao")){
            GetComponent<Animator>().SetBool("Jumping", false);
            podePular = true;
        }       
    }
}
