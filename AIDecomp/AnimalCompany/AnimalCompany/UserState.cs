using System;
using System.Runtime.CompilerServices;
using SpatialSys.ObservableState;

namespace AnimalCompany
{
    public sealed class UserState : StateObject
    {
        [CompilerGenerated]
        private StatePrimitive<string> <userID>k__BackingField;
        
        [CompilerGenerated]
        private StatePrimitive<string> <username>k__BackingField;
        
        [CompilerGenerated]
        private StatePrimitive<string> <displayName>k__BackingField;
        
        [CompilerGenerated]
        private StatePrimitive<string> <profilePictureURL>k__BackingField;
        
        [CompilerGenerated]
        private UserWalletState <wallet>k__BackingField;
        
        [CompilerGenerated]
        private StatePrimitive<bool> <isDeveloper>k__BackingField;

        public StatePrimitive<string> userID
        {
            [CompilerGenerated]
            get { return <userID>k__BackingField; }
            [CompilerGenerated]
            private set { <userID>k__BackingField = value; }
        }

        public StatePrimitive<string> username
        {
            [CompilerGenerated]
            get { return <username>k__BackingField; }
            [CompilerGenerated]
            private set { <username>k__BackingField = value; }
        }

        public StatePrimitive<string> displayName
        {
            [CompilerGenerated]
            get { return <displayName>k__BackingField; }
            [CompilerGenerated]
            private set { <displayName>k__BackingField = value; }
        }

        public StatePrimitive<string> profilePictureURL
        {
            [CompilerGenerated]
            get { return <profilePictureURL>k__BackingField; }
            [CompilerGenerated]
            private set { <profilePictureURL>k__BackingField = value; }
        }

        public UserWalletState wallet
        {
            [CompilerGenerated]
            get { return <wallet>k__BackingField; }
            [CompilerGenerated]
            private set { <wallet>k__BackingField = value; }
        }

        public StatePrimitive<bool> isDeveloper
        {
            [CompilerGenerated]
            get { return <isDeveloper>k__BackingField; }
            [CompilerGenerated]
            private set { <isDeveloper>k__BackingField = value; }
        }

        public UserState()
        {
        }
    }
}