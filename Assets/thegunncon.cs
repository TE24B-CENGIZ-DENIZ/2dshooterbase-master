using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;

public class thegunncon : MonoBehaviour
{

    [SerializeField]
    GameObject lilguy;
    void Start()
    {

    }

    void Update()
    {
        if (transform.position.y > 2.9f)
        {
            Vector2 position = new();
            position.y = 3;
            transform.position = position;
            GetComponent<Rigidbody2D>().sleepMode = RigidbodySleepMode2D.StartAsleep;
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "hero")
        {
            if (lilguy.GetComponent<SpriteRenderer>().flipX == false)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
            else
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }

        }
    }



}
