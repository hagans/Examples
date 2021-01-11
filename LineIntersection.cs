using UnityEngine;

public class LineIntersection : MonoBehaviour
{
    [SerializeField] Line line1 = default;
    [SerializeField] Line line2 = default;
    public void Update()
    {
        Debug.DrawLine(line1.a + line1.Direction * 100f, line1.a - line1.Direction * 100f);
        Debug.DrawLine(line2.a + line2.Direction * 100f, line2.a - line2.Direction * 100f);
        Debug.Log("Intersection at " + Line.Intersection(line1, line2));
    }

}


[System.Serializable]
public struct Line
{
    public Vector2 a;
    public Vector2 b;

    public static Vector2 Intersection(Line a, Line b)
    {
        return new Vector2
            (
                a.CrossProduct * b.DistanceY - b.CrossProduct * a.DistanceY,
                a.CrossProduct * b.DistanceX - b.CrossProduct * a.DistanceX
            ) / ((a.DistanceX * b.DistanceY) - (a.DistanceY * b.DistanceX));
    }

    public Vector2 Direction => b - a;

    float CrossProduct => a.x * b.y - a.y * b.x;

    float DistanceX => a.x - b.x;

    float DistanceY => a.y - b.y;
}
