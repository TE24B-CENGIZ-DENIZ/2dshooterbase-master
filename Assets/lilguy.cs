using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UIElements;
using System.IO.MemoryMappedFiles;
public class lilguy : MonoBehaviour
{
    [SerializeField]
    GameObject gunn;

    float lilhp = 0;
    [SerializeField]
    float lilmaxhp = 3;

    [SerializeField]
    float speed = 3.5f;

    [SerializeField]
    float jumpforce = 8.5f;

    [SerializeField]
    GameObject chec; //ground checker 

    [SerializeField]
    LayerMask groundlayer;


    void Start()
    {
        lilhp = lilmaxhp;
        
    }
    void FixedUpdate()
    {

        bool isgrounded = Physics2D.OverlapCircle(chec.transform.position, .08f, groundlayer);


        if (Input.GetAxisRaw("Jump") > 0 && isgrounded == true)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();

            rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
        }
    }
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");

        Vector2 movement2 = Vector2.right * inputX;
        if ( movement2 ==  Vector2.right)
        {

            
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {

            GetComponent<SpriteRenderer>().flipX = true;

        }

        transform.Translate(movement2 * speed * Time.deltaTime);
    
       
     
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {


            lilhp--;


            if (lilhp <= 0)
            {
                SceneManager.LoadScene("asa");
            }

        }
        if (collision.gameObject.tag == "gunn")
        {
            gunn.transform.parent = transform;
          

        }

    }



}
