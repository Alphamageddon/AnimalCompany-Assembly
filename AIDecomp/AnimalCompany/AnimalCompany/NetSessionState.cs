using System;
using System.Runtime.CompilerServices;
using SpatialSys.ObservableState;

namespace AnimalCompany
{
    public class NetSessionState : StateObject
    {
        [CompilerGenerated]
        private StatePrimitive<bool> <isConnected>k__BackingField;
        
        [CompilerGenerated]
        private StatePrimitive<string> <roomCode>k__BackingField;

        public StatePrimitive<bool> isConnected
        {
            [CompilerGenerated]
            get { return <isConnected>k__BackingField; }
            [CompilerGenerated]
            private set { <isConnected>k__BackingField = value; }
        }

        public StatePrimitive<string> roomCode
        {
            [CompilerGenerated]
            get { return <roomCode>k__BackingField; }
            [CompilerGenerated]
            private set { <roomCode>k__BackingField = value; }
        }

        public NetSessionState()
        {
        }

        protected virtual void PostInitialize()
        {
            var observerDelegate = new ObserverDelegate(this, <PostInitialize>b__8_0);
            isConnected?.AddObserver(observerDelegate);
        }

        [CompilerGenerated]
        private void <PostInitialize>b__8_0(StateChangedEventArgs args)
        {
            if (roomCode?.value != null)
            {
                bool isEmpty = string.IsNullOrEmpty(roomCode.value);
                if (isConnected != null)
                {
                    isConnected.value = !isEmpty;
                }
            }
        }

        [CompilerGenerated]
        public StatePrimitive<bool> get_isConnected()
        {
            return <isConnected>k__BackingField;
        }

        [CompilerGenerated]
        private void set_isConnected(StatePrimitive<bool> value)
        {
            <isConnected>k__BackingField = value;
        }

        [CompilerGenerated]
        public StatePrimitive<string> get_roomCode()
        {
            return <roomCode>k__BackingField;
        }

        [CompilerGenerated]
        private void set_roomCode(StatePrimitive<string> value)
        {
            <roomCode>k__BackingField = value;
        }
    }
}