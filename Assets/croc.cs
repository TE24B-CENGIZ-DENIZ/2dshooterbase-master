using UnityEngine;
using UnityEngine.UIElements;

public class croc : MonoBehaviour
{


    [SerializeField]
    float speed = 3.5f;

    [SerializeField]
    float jumpforce = 8.5f;

    [SerializeField]
    LayerMask groundlayer;

    [SerializeField]
    GameObject groundCheck;

    
    void Start()
    {
       
    }

    void FixedUpdate()
    {

        bool isgrounded = Physics2D.OverlapCircle(groundCheck.transform.position, .18f, groundlayer);


        if (Input.GetAxisRaw("Jump") > 0 && isgrounded == true)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();

            rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
        }


    }
      void Update()


    {

        Vector2 movement = Vector2.left * speed * Time.deltaTime;
        transform.Translate(movement);

    }
}