// Decompiled with Xera AI Decompiler
using System.Runtime.CompilerServices;

namespace AnimalCompany
{
    public class MobState
    {
        [CompilerGenerated]
        private bool <isDie>k__BackingField;
        
        [CompilerGenerated]
        private int <health>k__BackingField;
        
        [CompilerGenerated]
        private float <angerMeter>k__BackingField;
        
        [CompilerGenerated]
        private float <searchPrecision>k__BackingField;
        
        [CompilerGenerated]
        private float <searchWidth>k__BackingField;

        [Networked]
        public bool isDie
        {
            [CompilerGenerated]
            get { return <isDie>k__BackingField; }
            [CompilerGenerated]
            set { <isDie>k__BackingField = value; }
        }

        [Networked]
        public int health
        {
            [CompilerGenerated]
            get { return <health>k__BackingField; }
            [CompilerGenerated]
            set { <health>k__BackingField = value; }
        }

        [Networked]
        public float angerMeter
        {
            [CompilerGenerated]
            get { return <angerMeter>k__BackingField; }
            [CompilerGenerated]
            set { <angerMeter>k__BackingField = value; }
        }

        [Networked]
        public float searchPrecision
        {
            [CompilerGenerated]
            get { return <searchPrecision>k__BackingField; }
            [CompilerGenerated]
            set { <searchPrecision>k__BackingField = value; }
        }

        [Networked]
        public float searchWidth
        {
            [CompilerGenerated]
            get { return <searchWidth>k__BackingField; }
            [CompilerGenerated]
            set { <searchWidth>k__BackingField = value; }
        }

        public MobState()
        {
        }
    }
}