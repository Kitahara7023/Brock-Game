using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] private float speed = 5f;
    private Rigidbody2D myRigidbody;
    private bool hasLaunched = false;

    void Awake()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // スペースキーを押したら一度だけ Initialize で発射
        if (Input.GetKeyDown(KeyCode.Space) && !hasLaunched)
        {
            Initialize();
        }
    }

    public void Initialize()
    {
        hasLaunched = true;

        if(myRigidbody != null)
        {
            // ランダムな角度で上方向に飛ばす
            Vector2 direction = (Vector2.up + new Vector2(Random.Range(-0.3f, 0.3f), 0)).normalized;
            myRigidbody.linearVelocity = direction * speed;
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
