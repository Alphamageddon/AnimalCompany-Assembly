// Decompiled with Xera AI Decompiler
using System.Collections.Generic;
using UnityEngine;

namespace AnimalCompany.GameGen
{
    [CreateAssetMenu(fileName = "RoomTileset", menuName = "GameGen/Tile Set", order = 1)]
    public class Tileset : ScriptableObject
    {
        public List<WeightedRoomTile> tiles;

        public Tileset()
        {
            tiles = new List<WeightedRoomTile>();
        }
    }
}