using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UIElements;

public class croc : MonoBehaviour
{

    float crochp = 0;
    [SerializeField]
    float crocmaxhp = 3;

    [SerializeField]
    GameObject target;

    [SerializeField]
    float speed = 3.5f;


    [SerializeField]
    LayerMask groundlayer;




    void Start()
    {
        crochp = crocmaxhp;
    }

    void FixedUpdate()
    {

        bool isgrounded = Physics2D.OverlapCircle(transform.position, groundlayer);


        if (isgrounded == true)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();

        }


    }
    void Update()


    {



        if (target.transform.position.x < transform.position.x)
        {

            Vector2 movement = Vector2.left * speed * Time.deltaTime;
            transform.Translate(movement);
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            Vector2 movement = Vector2.right * speed * Time.deltaTime;
            transform.Translate(movement);

            GetComponent<SpriteRenderer>().flipX = true;

        }







    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "hero")
        {
            print("ouch");
            crochp--;

        }

        if (crochp <= 0)
        {
            Destroy(this.gameObject);
        }

    }







}