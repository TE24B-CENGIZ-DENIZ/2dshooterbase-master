using UnityEngine;

public class crocspawner : MonoBehaviour
{
    [SerializeField]
    GameObject croc;

    float timesincelastcrocspawn = 0;

    float timebetweenencrocspawn = 15;

    void Start()
    {
        Vector2 position = new();
        position.x = Random.Range(-8, 8);
        position.y = Random.Range(8, 5);

        transform.position = position;
    }


    void Update()
    {
        timesincelastcrocspawn += Time.deltaTime;
        if(timesincelastcrocspawn> timebetweenencrocspawn)
        {
            Instantiate(croc, transform.position, Quaternion.identity);
            timesincelastcrocspawn = 0;
        }
    }
}
