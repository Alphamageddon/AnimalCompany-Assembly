// Decompiled with Xera AI Decompiler
using UnityEngine;
using UnityEngine.Tilemaps;

namespace AnimalCompany.GameGen
{
    public class RuleTile : Tile
    {
        [Header("Rule Tile Settings")]
        public RuledTileset ruledTileset;
        
        [Space]
        public Socket posZSocket;
        public Socket negZSocket;
        public Socket posXSocket;
        public Socket negXSocket;

        public RuleTile()
        {
        }

        public virtual void RenderTile(Archetype archetype)
        {
            if (ruledTileset == null)
                return;

            // Get tile data from archetype
            var tileData = GetTileData(archetype);
            if (tileData == null)
                return;

            // Check socket connections
            int socketMask = 0;
            if (posZSocket != null && posZSocket.socketType != 0)
                socketMask |= 1;
            if (negZSocket != null && negZSocket.socketType != 0)
                socketMask |= 2;
            if (posXSocket != null && posXSocket.socketType != 0)
                socketMask |= 4;
            if (negXSocket != null && negXSocket.socketType != 0)
                socketMask |= 8;

            // Get appropriate tile from ruleset based on socket configuration
            GameObject selectedTile = null;
            if (socketMask > 0)
            {
                selectedTile = ruledTileset.GetRandomTile(socketMask);
            }

            if (selectedTile == null)
            {
                selectedTile = ruledTileset.GetRandomTile(0);
            }

            if (selectedTile != null)
            {
                // Instantiate and position the tile
                var instantiatedTile = Instantiate(selectedTile);
                if (instantiatedTile != null)
                {
                    var tileTransform = instantiatedTile.transform;
                    var parentTransform = transform;

                    if (parentTransform != null)
                    {
                        tileTransform.position = parentTransform.position;
                        
                        // Apply rotation based on socket configuration
                        float rotationY = socketMask * 90f;
                        tileTransform.localRotation = Quaternion.Euler(0, rotationY, 0) * parentTransform.rotation;
                        
                        // Set parent
                        tileTransform.SetParent(parentTransform, true);
                    }

                    // Render child tiles if this is a RuleTile
                    var childRuleTile = instantiatedTile.GetComponent<RuleTile>();
                    if (childRuleTile != null)
                    {
                        childRuleTile.RenderTile(archetype);
                    }
                }
            }
        }

        private TileData GetTileData(Archetype archetype)
        {
            // Implementation would depend on the TileData structure
            // This is a placeholder based on the IL analysis
            return null;
        }
    }
}