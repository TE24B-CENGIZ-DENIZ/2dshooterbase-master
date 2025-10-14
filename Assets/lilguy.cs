using UnityEngine;

public class lilguy : MonoBehaviour
{
     [SerializeField]
    float speed = 3.5f;

    [SerializeField]
    float jumpforce = 8.5f;

    [SerializeField]
    GameObject chec; //ground checker 

    [SerializeField]
    LayerMask groundlayer;
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

          Vector2 movement2 =   Vector2.right * inputX;

        transform.Translate(movement2 * speed * Time.deltaTime);
    }
}
