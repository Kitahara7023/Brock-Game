using UnityEngine;
using static NewRect;

public class Wall : MonoBehaviour
{
    [SerializeField] private Vector2 size;

    public MyRect Rect;

    private void Start()
    {
        Rect = new MyRect(transform.position, size);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position, size);
    }

}
