using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed = 10f; // プレイヤーの移動速度

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(playerSpeed* Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-playerSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(playerSpeed* Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(-playerSpeed * Time.deltaTime, 0, 0);
        }
    }
}
