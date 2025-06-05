// Decompiled with Xera AI Decompiler
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace AnimalCompany.GameGen
{
    public struct NavZone
    {
        public int zoneID;
        public NavPoint[] navPoints;
        public NavPoint[] spawnablePoints;

        public NavZone(NavPoint[] points, int ID)
        {
            zoneID = ID;
            navPoints = points;
            
            if (points != null)
            {
                List<NavPoint> spawnableList = new List<NavPoint>();
                
                for (int i = 0; i < points.Length; i++)
                {
                    NavPoint point = points[i];
                    if (point.isSpawnable)
                    {
                        spawnableList.Add(point);
                    }
                }
                
                spawnablePoints = spawnableList.ToArray();
            }
            else
            {
                spawnablePoints = null;
            }
        }

        public NavPoint GetRandomPoint()
        {
            if (navPoints != null && navPoints.Length > 0)
            {
                int randomIndex = Random.Range(0, navPoints.Length);
                return navPoints[randomIndex];
            }
            
            return default(NavPoint);
        }

        public NavPoint GetRandomSpawnablePoint()
        {
            if (spawnablePoints != null && spawnablePoints.Length > 0)
            {
                int randomIndex = Random.Range(0, spawnablePoints.Length);
                return spawnablePoints[randomIndex];
            }
            
            return default(NavPoint);
        }
    }
}