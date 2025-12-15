using UnityEngine;

public class NewRect : MonoBehaviour
{
    [SerializeField] Vector2 size;

    public MyRect Rect;

    public void Start()
    {
        Rect = new MyRect(transform.position, size);
    }

    public struct MyRect
    {
        public readonly Vector2 Position;
        public readonly Vector2 Size;

        public float Left => Position.x - Size.x / 2;
        public float Right => Position.x + Size.x / 2;
        public float Top => Position.y + Size.y / 2;
        public float Bottom => Position.y - Size.y / 2;

        public MyRect(Vector2 position, Vector2 size)
        {
            Position = position;
            Size = size;
        }

        public bool Intersects(MyRect other)
        {
            return Left < other.Right &&
                   Right > other.Left &&
                   Top > other.Bottom &&
                   Bottom < other.Top;
        }
    }
}
