// Decompiled with Xera AI Decompiler
using System.Collections.Generic;
using UnityEngine;

namespace AnimalCompany.GameGen
{
    public class NodeGenerationResult
    {
        public Archetype archetype;
        public GameObject parentObject;
        public List<Tile> tiles;
        public List<NavPoint> navPoints;
        public List<ItemPoint> itemPoints;
        public NavZone navZone;

        public NodeGenerationResult()
        {
            tiles = new List<Tile>();
            navPoints = new List<NavPoint>();
            itemPoints = new List<ItemPoint>();
        }
    }
}