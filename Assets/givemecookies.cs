using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class givemecookies : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    float speed = 3.5f;


    [SerializeField]
    GameObject boltPrefab;

    float timesincelastshot = 0;
    [SerializeField]
    float timebetweenshots = 0.5f;


    float currenthp = 0;
    [SerializeField]
    float maxhp = 3;

    [SerializeField]
    Slider hpslider ;


    void Start()
    {
        currenthp = maxhp;
        hpslider.maxValue = maxhp;
        hpslider.value = currenthp;
    }


    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        //"raw" imidiot movement
        float inputy = Input.GetAxisRaw("Vertical");

        Vector2 movement2 = Vector2.up * inputy + Vector2.right * inputX;

        transform.Translate(movement2 * speed * Time.deltaTime);
        //-------

        timesincelastshot += Time.deltaTime;

        if (Input.GetAxisRaw("Fire1") > 0 && timesincelastshot > timebetweenshots)
        {
            AudioSource speaker = GetComponent<AudioSource>();

            speaker.Play();

            Instantiate(boltPrefab, transform.position, Quaternion.identity);
            timesincelastshot = 0;
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            currenthp--; //-=1 
            print(currenthp);
            hpslider.value = currenthp;

            if (currenthp <= 0)
            {
                SceneManager.LoadScene("GAME OVER");
            }
        }


    }
}
// float = string
// audio,  getcomponenet<audiosource>().play();