using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] private float speed = 5f;
    private Rigidbody2D myRigidbody;
    private bool hasLaunched = false;
    private Vector2 direction;

    void Awake()
    {
        myRigidbody = GetComponent<Rigidbody2D>();

        myRigidbody.gravityScale = 0f;
        myRigidbody.linearDamping = 0f;
        myRigidbody.angularDamping = 0f;
    }

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space) && !hasLaunched)
        {
            Initialize();
        }
    }

    void FixedUpdate()
    {
        if (hasLaunched)
        {
            myRigidbody.linearVelocity = direction * speed;
        }
    }
    

    public void Initialize()
    {
        hasLaunched = true;

        direction = (Vector2.up + new Vector2(Random.Range(-0.3f, 0.3f), 0)).normalized;

        myRigidbody.linearVelocity = direction * speed;
       
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 衝突時に自分で反射ベクトルを計算
        foreach (ContactPoint2D contact in collision.contacts)
        {
            direction = Vector2.Reflect(direction, contact.normal).normalized;
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
