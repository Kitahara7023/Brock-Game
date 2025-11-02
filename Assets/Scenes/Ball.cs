using UnityEngine;



public class Ball : MonoBehaviour
{
    //[SerializeField] private GameObject ballPrefab;
    [SerializeField] private float speed = 5f;
    private Rigidbody2D myRigidbody;

    void Awake()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    public void Initialize(Vector2 startPosition)
    {
        transform.position = startPosition; // バーの上に配置

        if (myRigidbody != null)
        {
            // 上方向に飛ばす（ブロック崩しらしい動き）
            myRigidbody.linearVelocity = Vector2.up * speed;
        }
    }
}
    /*
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            var newball = Instantiate(ballPrefab);

            var ball = newball.GetComponent<Ball>();

            ball.Initialize();
        }
    }
    public void Initialize() 
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        if (myRigidbody != null)
        {
            
            myRigidbody.linearVelocity = new Vector2(1, 1).normalized * speed;
        }
    }

   
}
    */
