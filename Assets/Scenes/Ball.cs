using UnityEngine;



public class Ball : MonoBehaviour
{
    [SerializeField]
    private GameObject ballPrefab;

    public void Initialize() { }

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            var newball = Instantiate(ballPrefab);
            var ball = newball.GetComponent<Ball>();
            ball.Initialize();
        }    
    }
}
