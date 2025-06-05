// Decompiled with Xera AI Decompiler
using UnityEngine;
using Less3.ForceGraph;

namespace AnimalCompany.GameGen
{
    public class MobPlacementConnection : ForceConnection, IForceConnectionStyle
    {
        private static bool _colorInitialized = false;
        private static Color _cachedColor;

        public override Color ConnectionColor
        {
            get
            {
                if (!_colorInitialized)
                {
                    if (ColorUtility.TryParseHtmlString("#FF0000", out Color parsedColor))
                    {
                        _cachedColor = parsedColor;
                    }
                    else
                    {
                        _cachedColor = new Color(1f, 0f, 0f, 1f);
                    }
                    _colorInitialized = true;
                }
                return _cachedColor;
            }
        }

        public override bool Dashed
        {
            get
            {
                return false;
            }
        }

        public MobPlacementConnection()
        {
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
            if (StartNode == node)
            {
                return EndNode;
            }
            else if (EndNode == node)
            {
                return StartNode;
            }
            return null;
        }
    }
}