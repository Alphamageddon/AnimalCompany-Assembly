// Decompiled with Xera AI Decompiler
using System.Collections.Generic;
using UnityEngine;

namespace AnimalCompany.GameGen
{
    [CreateAssetMenu(fileName = "RuledTileset", menuName = "GameGen/Ruled Tile Set")]
    public class RuledTileset : ScriptableObject
    {
        [HideArrayElementLabel]
        public List<RuledTile> tiles_Open;
        
        [HideArrayElementLabel]
        [Space]
        public List<RuledTile> tiles_I;
        
        [HideArrayElementLabel]
        [Space]
        public List<RuledTile> tiles_L;
        
        [HideArrayElementLabel]
        [Space]
        public List<RuledTile> tiles_II;
        
        [HideArrayElementLabel]
        [Space]
        public List<RuledTile> tiles_U;
        
        [HideArrayElementLabel]
        [Space]
        public List<RuledTile> tiles_Closed;

        public RuledTileset()
        {
            tiles_Open = new List<RuledTile>();
            tiles_I = new List<RuledTile>();
            tiles_L = new List<RuledTile>();
            tiles_II = new List<RuledTile>();
            tiles_U = new List<RuledTile>();
            tiles_Closed = new List<RuledTile>();
        }

        public RuledTile GetRandomTile(TileRuleType rule)
        {
            List<RuledTile> tileList = null;
            
            switch (rule)
            {
                case TileRuleType.Open:
                    tileList = tiles_Open;
                    break;
                case TileRuleType.I:
                    tileList = tiles_I;
                    break;
                case TileRuleType.L:
                    tileList = tiles_L;
                    break;
                case TileRuleType.II:
                    tileList = tiles_II;
                    break;
                case TileRuleType.U:
                    tileList = tiles_U;
                    break;
                case TileRuleType.Closed:
                    tileList = tiles_Closed;
                    break;
            }
            
            if (tileList == null || tileList.Count == 0)
            {
                Debug.LogError($"No tiles found for rule type: {rule}");
                return null;
            }
            
            int randomIndex = Random.Range(0, tileList.Count);
            return tileList[randomIndex];
        }
    }
}