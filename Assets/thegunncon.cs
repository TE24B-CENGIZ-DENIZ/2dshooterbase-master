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
