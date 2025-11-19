using UnityEngine;

public class boltcontroler : MonoBehaviour
{

    [SerializeField]
    float boltspeed = 4;

  
    
   

    void Start()
    {
        // Destroy(this.gameObject, 3);
        
    }
    //decimal sec write  f after



    void Update()
    {

        Vector2 movement = Vector2.left * boltspeed * Time.deltaTime;
        transform.Translate(movement);

        // if (tranform.position.y > Camera.main.orthographicSize + 1)

        if (transform.position.x > 15 || transform.position.x < -15)
        {
            Destroy(this.gameObject);
        }


    }
    
    void OnTriggerEnter2D( Collider2D  collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
          
        }
       
    }
}

