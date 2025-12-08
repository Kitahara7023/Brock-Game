using UnityEngine;

public class Wall : MonoBehaviour
{
    public struct Rect
    {
        public readonly Vector2 Position;
        public readonly Vector2 Size;

        public float Left => Position.x - Size.x / 2;
        public float Right => Position.x + Size.x / 2;
        public float Top => Position.y + Size.y / 2;
        public float Bottom => Position.y - Size.y / 2;

        public Rect(Vector2 position, Vector2 size)
        {
            Position = position;
            Size = size;
        }

        public bool Intersects(Rect other)
        {
            return Left < other.Right && Right > other.Left && Top > other.Bottom && Bottom < other.Top;
        }

    }
    
}
