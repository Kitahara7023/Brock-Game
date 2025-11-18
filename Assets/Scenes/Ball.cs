using UnityEngine;

public class Ball : MonoBehaviour
{
    
    private float speed;
    
    private bool hasLaunched = false;
    private Vector3 direction;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !hasLaunched)
        {
            
        }
    }

    void FixedUpdate()
    {
        if (hasLaunched)
        {
            
        }
    }

    public void OnStart()
    {
        Debug.Log("OnStart");
        direction = new Vector2(1,1);
        speed = 3;
    }

    public void OnUpdate()
    {
        Debug.Log("OnUpdate");
        transform.position += direction.normalized * speed * Time.deltaTime;
    }

    public void Initialize()
    {
        hasLaunched = true;

        direction = (Vector2.up + new Vector2(Random.Range(-0.3f, 0.3f), 0)).normalized;

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
