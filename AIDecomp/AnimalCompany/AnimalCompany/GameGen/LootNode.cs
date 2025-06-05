// Decompiled with Xera AI Decompiler
using System.Collections.Generic;
using UnityEngine;

namespace AnimalCompany.GameGen
{
    public class LootNode : ForceNode, IForceNodeStyle, IForceNodeIcon, IForceNodeTitle
    {
        public int value;
        public List<ItemSet> itemSets;

        public override Color NodeBackgroundColor
        {
            get
            {
                Color color;
                if (ColorUtility.TryParseHtmlString("#FED766", out color))
                {
                    return color;
                }
                return new Color(1f, 1f, 0f, 1f);
            }
        }

        public override Color NodeLabelColor
        {
            get
            {
                return new Color(0f, 0f, 0f, 1f);
            }
        }

        public override string NodeIcon
        {
            get
            {
                return "treasure-map";
            }
        }

        public override string NodeTitle
        {
            get
            {
                return string.Format("Loot ({0})", value);
            }
        }

        public LootNode()
        {
            itemSets = new List<ItemSet>();
        }
    }
}