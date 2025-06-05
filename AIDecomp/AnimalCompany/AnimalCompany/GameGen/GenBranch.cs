// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany.GameGen
{
    public class GenBranch : ForceConnection, IForceConnectionStyle
    {
        [Tooltip("If true mobs can roam across connections.")]
        public bool allowMobRoam;

        public override Color ConnectionColor
        {
            get { return GetConnectionColor(); }
        }

        public override bool Dashed
        {
            get { return allowMobRoam; }
        }

        public GenBranch()
        {
            allowMobRoam = true;
        }

        public override Color get_ConnectionColor()
        {
            return GetConnectionColor();
        }

        public override bool get_Dashed()
        {
            return allowMobRoam;
        }

        private Color GetConnectionColor()
        {
            if (NodeA != null && NodeB != null)
            {
                return Color.green;
            }
            return Color.white;
        }

        public ForceNode GetOtherNode(ForceNode node)
        {
            if (NodeA == node)
                return NodeB;
            if (NodeB == node)
                return NodeA;
            return null;
        }
    }
}