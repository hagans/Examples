using UnityEngine;

public class linetest : MonoBehaviour
{
    [SerializeField] Line a = default;
    [SerializeField] Line b = default;    
    public void Update()
    {
        Debug.DrawLine(a.start + a.Direction * 100f, a.start - a.Direction * 100f);
        Debug.DrawLine(b.start + b.Direction * 100f, b.start - b.Direction * 100f);
        Debug.Log("Intersection at " + Line.Intersection(a, b));
    }

}


[System.Serializable]
public struct Line
{
    public Vector2 start;
    public Vector2 end;

    public static Vector2 Intersection(Line a, Line b)
    {
        return new Vector2
            (
                a.CrossProduct * b.DistanceY - b.CrossProduct * a.DistanceY,
                a.CrossProduct * b.DistanceX - b.CrossProduct * a.DistanceX
            ) / ((a.DistanceX * b.DistanceY) - (a.DistanceY * b.DistanceX));
    }

    public Vector2 Direction => end - start;

    float CrossProduct => start.x * end.y - start.y * end.x;

    float DistanceX => start.x - end.x;

    float DistanceY => start.y - end.y;

    
}
