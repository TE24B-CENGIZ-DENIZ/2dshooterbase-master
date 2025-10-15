using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UIElements;

public class croc : MonoBehaviour
{


    [SerializeField]
    GameObject target;

    [SerializeField]
    float speed = 3.5f;


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
}