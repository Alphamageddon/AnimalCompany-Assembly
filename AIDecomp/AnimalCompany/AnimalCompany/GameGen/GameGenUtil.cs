// Decompiled with Xera AI Decompiler
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AnimalCompany.GameGen
{
    public static class GameGenUtil
    {
        [CompilerGenerated]
        private sealed class <>c
        {
            public static readonly <>c <>9 = new <>c();
            public static Func<Socket, float> <>9__1_1;

            internal float <lowestXCoord>b__1_1(Socket y)
            {
                if (y == null) return 0f;
                Transform transform = y.GetComponent<Transform>();
                if (transform == null) return 0f;
                return transform.position.x;
            }
        }

        [CompilerGenerated]
        private sealed class <>c__DisplayClass1_0
        {
            public List<Socket> array;

            internal bool <lowestXCoord>b__0(Socket p)
            {
                if (p == null || array == null) return false;
                Transform transform = p.GetComponent<Transform>();
                if (transform == null) return false;
                return array.Contains(p);
            }
        }

        public static float ccw(Socket p1, Socket p2, Socket p3)
        {
            if (p1 == null || p2 == null || p3 == null) return 0f;

            Transform t1 = p1.GetComponent<Transform>();
            Transform t2 = p2.GetComponent<Transform>();
            Transform t3 = p3.GetComponent<Transform>();

            if (t1 == null || t2 == null || t3 == null) return 0f;

            Vector3 pos1 = t1.position;
            Vector3 pos2 = t2.position;
            Vector3 pos3 = t3.position;

            float cross = (pos2.x - pos1.x) * (pos3.z - pos1.z) - (pos3.x - pos1.x) * (pos2.z - pos1.z);
            
            if (cross < 0f) return -1f;
            if (cross > 0f) return 1f;
            return 0f;
        }

        public static List<Socket> GetOuterSockets(List<Socket> points)
        {
            if (points == null || points.Count == 0) return new List<Socket>();

            List<Socket> hull = new List<Socket>();
            Socket start = lowestXCoord(points);
            
            if (start == null) return hull;

            hull.Add(start);
            Socket current = start;
            Socket next;

            do
            {
                next = null;
                for (int i = 0; i < points.Count; i++)
                {
                    if (points[i] == current) continue;
                    
                    if (next == null)
                    {
                        next = points[i];
                        continue;
                    }

                    float orientation = ccw(current, next, points[i]);
                    if (orientation > 0f)
                    {
                        next = points[i];
                    }
                }

                if (next != null && next != start)
                {
                    hull.Add(next);
                    current = next;
                }
            }
            while (next != null && next != start);

            return hull;
        }

        private static Socket lowestXCoord(List<Socket> array)
        {
            if (array == null || array.Count == 0) return null;

            <>c__DisplayClass1_0 displayClass = new <>c__DisplayClass1_0();
            displayClass.array = array;

            var validSockets = array.Where(displayClass.<lowestXCoord>b__0);
            
            if (<>c.<>9__1_1 == null)
            {
                <>c.<>9__1_1 = new Func<Socket, float>(<>c.<>9.<lowestXCoord>b__1_1);
            }

            return validSockets.OrderBy(<>c.<>9__1_1).FirstOrDefault();
        }
    }
}