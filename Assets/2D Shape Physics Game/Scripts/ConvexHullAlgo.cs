using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class ConvexHullAlgo : MonoBehaviour
{

    private void Start()
    {
        //List<Vector2> points = new List<Vector2>() {
        //        new Vector2(16, 3),
        //        new Vector2(12, 17),
        //        new Vector2(0, 6),
        //        new Vector2(-4, -6),
        //        new Vector2(16, 6),

        //        new Vector2(16, -7),
        //        new Vector2(16, -3),
        //        new Vector2(17, -4),
        //        new Vector2(5, 19),
        //        new Vector2(19, -8),

        //        new Vector2(3, 16),
        //        new Vector2(12, 13),
        //        new Vector2(3, -4),
        //        new Vector2(17, 5),
        //        new Vector2(-3, 15),

        //        new Vector2(-3, -9),
        //        new Vector2(0, 11),
        //        new Vector2(-9, -3),
        //        new Vector2(-4, -2),
        //        new Vector2(12, 10)
        //    };

        //List<Vector2> hull = ConvexHull(points);
        //Debug.Log("Convex Hull: [");
        //for (int i = 0; i < hull.Count; i++)
        //{
        //    if (i > 0)
        //    {
        //        Debug.Log(", ");
        //    }
        //    Vector2 pt = hull[i];
        //    Debug.Log(pt);
        //}
        //Debug.Log("]");

    }



    public static List<Vector2> ConvexHull(List<Vector2> p)
    {
        if (p.Count == 0) return new List<Vector2>();
        p.Sort((a, b) =>
            a.x == b.x ? a.y.CompareTo(b.y) : (a.x > b.x ? 1 : -1));

        List<Vector2> h = new List<Vector2>();

        // lower hull
        foreach (var pt in p)
        {
            while (h.Count >= 2 && !Ccw(h[h.Count - 2], h[h.Count - 1], pt))
            {
                h.RemoveAt(h.Count - 1);
            }
            h.Add(pt);
        }

        // upper hull
        int t = h.Count + 1;
        for (int i = p.Count - 1; i >= 0; i--)
        {
            Vector2 pt = p[i];
            while (h.Count >= t && !Ccw(h[h.Count - 2], h[h.Count - 1], pt))
            {
                h.RemoveAt(h.Count - 1);
            }
            h.Add(pt);
        }

        h.RemoveAt(h.Count - 1);
        return h;
    }

    private static bool Ccw(Vector2 a, Vector2 b, Vector2 c)
    {
        return ((b.x - a.x) * (c.y - a.y)) > ((b.y - a.y) * (c.x - a.x));
    }



}

//class Point : IComparable<Point>
//{
//    private int x, y;

//    public Point(int x, int y)
//    {
//        this.x = x;
//        this.y = y;
//    }

//    public int X { get { return x; } set { x = value; } }
//    public int Y { get { return y; } set { y = value; } }

//    public int CompareTo(Point other)
//    {
//        return x.CompareTo(other.x);
//    }

//    public override string ToString()
//    {
//        return string.Format("({0}, {1})", x, y);
//    }
//}