// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany.GameGen
{
    public class GenEntry : ForceNode, IForceNodeStyle, IForceNodeTitle, IForceNodeIcon
    {
        [Tooltip("If a graph has multiple entry nodes one will be chosen at random to start the generation based off weight. If an entry node has multiple branches only one will be chosen at random.")]
        public float weight = 1.0f;

        public override Color NodeBackgroundColor
        {
            get { return new Color(0f, 1f, 0f, 1f); }
        }

        public override Color NodeLabelColor
        {
            get { return new Color(0f, 0f, 0f, 1f); }
        }

        public override string NodeTitle
        {
            get { return "Entry"; }
        }

        public override string NodeIcon
        {
            get { return "d_winbtn_mac_inact"; }
        }

        public GenEntry()
        {
            weight = 1.0f;
        }
    }
}