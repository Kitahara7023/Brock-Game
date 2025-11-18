using UnityEngine;

public class Stage : MonoBehaviour
{
    [SerializeField] GameObject Ballprehub;
    
    private Ball _ball;
    


    void Start()
    {
        var ballObject = Instantiate(Ballprehub);
        var ball = ballObject.GetComponent<Ball>();
        ball.OnStart();
        _ball = ball;
    }
   
    void Update()
    {
        _ball.OnUpdate();
        
    }
}
