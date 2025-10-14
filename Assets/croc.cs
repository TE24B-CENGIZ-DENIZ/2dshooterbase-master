using UnityEngine;

public class croc : MonoBehaviour
{

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

        // Update is called once per frame
        void Update()
        {

        }
    }
}