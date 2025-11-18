using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;

public class thegunncon : MonoBehaviour
{ 
     [SerializeField]
    GameObject boltPrefab;

    [SerializeField]
    GameObject lilguy;



     float timesincelastshot = 0;
    [SerializeField]
    float timebetweenshots = 0.5f;
    void Start()
    {

    }

    void Update()
    {
         timesincelastshot += Time.deltaTime;

        if (Input.GetAxisRaw("Fire1") > 0 && timesincelastshot > timebetweenshots)
        {
            

            Instantiate(boltPrefab, transform.position, Quaternion.identity);
            timesincelastshot = 0;
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
