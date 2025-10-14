using UnityEngine;

public class enemycontroller : MonoBehaviour
{


    [SerializeField]
    GameObject boomPrefab;

    float enemyspeed = 2.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector2 position = new();
        position.x = Random.Range(-8, 8);
        position.y = Random.Range(8, 5);

        transform.position = position;
    }

    // Update is called once per frame
    void Update()


    {

        Vector2 movement = Vector2.down * enemyspeed * Time.deltaTime;
        transform.Translate(movement);

        if (transform.position.y < -6)
        {
            Destroy(this.gameObject);
        }



    }

    void OnTriggerEnter2D( Collider2D  collision)
    {
        Instantiate(boomPrefab, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
