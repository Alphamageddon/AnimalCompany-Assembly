// Decompiled with Xera AI Decompiler
using System;
using System.Runtime.CompilerServices;
using SpatialSys.ObservableState;

namespace AnimalCompany
{
    public class UserWalletState : StateObject
    {
        [CompilerGenerated]
        private StatePrimitive<int> <softCurrency>k__BackingField;

        public StatePrimitive<int> softCurrency
        {
            [CompilerGenerated]
            get { return <softCurrency>k__BackingField; }
            [CompilerGenerated]
            private set { <softCurrency>k__BackingField = value; }
        }

        public UserWalletState()
        {
        }

        [CompilerGenerated]
        public StatePrimitive<int> get_softCurrency()
        {
            return <softCurrency>k__BackingField;
        }

        [CompilerGenerated]
        private void set_softCurrency(StatePrimitive<int> value)
        {
            <softCurrency>k__BackingField = value;
        }
    }
}