// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany.GameGen
{
    public class LootPlacementConnection : ForceConnection, IForceConnectionStyle
    {
        [Tooltip("When placing items, a node evaultes all its connection for every item and places into a node randomly based on the connection weights.")]
        public int weight = 1;

        public override Color ConnectionColor
        {
            get
            {
                Color color;
                if (ColorUtility.TryParseHtmlString("#FF6B35", out color))
                {
                    return color;
                }
                return new Color(1f, 0.42f, 0.21f, 1f);
            }
        }

        public override bool Dashed
        {
            get { return false; }
        }

        public LootPlacementConnection()
        {
            weight = 1;
        }

        public override Color get_ConnectionColor()
        {
            return ConnectionColor;
        }

        public override bool get_Dashed()
        {
            return Dashed;
        }

        public ForceNode GetOtherNode(ForceNode node)
        {
            if (nodeA == node)
            {
                return nodeB;
            }
            else if (nodeB == node)
            {
                return nodeA;
            }
            return null;
        }
    }
}