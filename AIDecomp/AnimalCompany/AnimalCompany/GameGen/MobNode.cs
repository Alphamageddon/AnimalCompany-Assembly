// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany.GameGen
{
    public class MobNode : ForceNode, IForceNodeStyle, IForceNodeIcon, IForceNodeTitle
    {
        public string label;
        public GameObject mob;
        public int spawnCount;

        public override Color NodeBackgroundColor
        {
            get
            {
                if (mob != null)
                {
                    Color color;
                    if (ColorUtility.TryParseHtmlString("#FF6B6B", out color))
                    {
                        return color;
                    }
                }
                return new Color(1f, 0f, 0f, 1f);
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
                return "🐾";
            }
        }

        public override string NodeTitle
        {
            get
            {
                return GetTitle();
            }
        }

        public MobNode()
        {
            spawnCount = 1;
        }

        private string GetTitle()
        {
            if (string.IsNullOrEmpty(label))
            {
                if (spawnCount > 1)
                {
                    return string.Format("{0} x{1}", label ?? "Mob", spawnCount);
                }
                return "Mob";
            }
            
            if (spawnCount > 1)
            {
                return string.Format("{0} x{1}", label, spawnCount);
            }
            
            return label;
        }
    }
}