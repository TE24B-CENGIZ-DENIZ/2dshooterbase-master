using UnityEngine;

public class enemyspawner : MonoBehaviour
{

    [SerializeField]
    GameObject enemyPrefab; 


    float timesincelastenemyspawn = 0;

    float timebetweenenemyspawn = 0.45f ;

    void Update()
    {
        
         timesincelastenemyspawn +=  Time.deltaTime;
        if (timesincelastenemyspawn > timebetweenenemyspawn)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            timesincelastenemyspawn = 0;
        }
       

    }
}
