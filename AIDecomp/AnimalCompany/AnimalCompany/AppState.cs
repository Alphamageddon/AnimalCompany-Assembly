// Decompiled with Xera AI Decompiler
using System;
using System.Runtime.CompilerServices;
using SpatialSys.ObservableState;

namespace AnimalCompany
{
    public sealed class AppState : StateRoot
    {
        [CompilerGenerated]
        private StatePrimitive<bool> <startupCompleted>k__BackingField;
        
        [CompilerGenerated]
        private StatePrimitive<AppPlatform> <platform>k__BackingField;
        
        [CompilerGenerated]
        private StatePrimitive<string> <clientVersion>k__BackingField;
        
        [CompilerGenerated]
        private StatePrimitive<string> <clientVersionSHA>k__BackingField;
        
        [CompilerGenerated]
        private StatePrimitive<string> <clientUserAgent>k__BackingField;
        
        [CompilerGenerated]
        private StatePrimitive<string> <apiOrigin>k__BackingField;
        
        [CompilerGenerated]
        private StatePrimitive<string> <apiToken>k__BackingField;
        
        [CompilerGenerated]
        private StatePrimitive<bool> <isLoggedIn>k__BackingField;
        
        [CompilerGenerated]
        private StatePrimitive<bool> <apiSocketConnected>k__BackingField;
        
        [CompilerGenerated]
        private UserState <user>k__BackingField;
        
        [CompilerGenerated]
        private NetSessionState <netSession>k__BackingField;
        
        [CompilerGenerated]
        private DebugState <debug>k__BackingField;

        public StatePrimitive<bool> startupCompleted
        {
            [CompilerGenerated]
            get { return <startupCompleted>k__BackingField; }
            [CompilerGenerated]
            private set { <startupCompleted>k__BackingField = value; }
        }

        public StatePrimitive<AppPlatform> platform
        {
            [CompilerGenerated]
            get { return <platform>k__BackingField; }
            [CompilerGenerated]
            private set { <platform>k__BackingField = value; }
        }

        public StatePrimitive<string> clientVersion
        {
            [CompilerGenerated]
            get { return <clientVersion>k__BackingField; }
            [CompilerGenerated]
            private set { <clientVersion>k__BackingField = value; }
        }

        public StatePrimitive<string> clientVersionSHA
        {
            [CompilerGenerated]
            get { return <clientVersionSHA>k__BackingField; }
            [CompilerGenerated]
            private set { <clientVersionSHA>k__BackingField = value; }
        }

        public StatePrimitive<string> clientUserAgent
        {
            [CompilerGenerated]
            get { return <clientUserAgent>k__BackingField; }
            [CompilerGenerated]
            private set { <clientUserAgent>k__BackingField = value; }
        }

        public StatePrimitive<string> apiOrigin
        {
            [CompilerGenerated]
            get { return <apiOrigin>k__BackingField; }
            [CompilerGenerated]
            private set { <apiOrigin>k__BackingField = value; }
        }

        public StatePrimitive<string> apiToken
        {
            [CompilerGenerated]
            get { return <apiToken>k__BackingField; }
            [CompilerGenerated]
            private set { <apiToken>k__BackingField = value; }
        }

        public StatePrimitive<bool> isLoggedIn
        {
            [CompilerGenerated]
            get { return <isLoggedIn>k__BackingField; }
            [CompilerGenerated]
            private set { <isLoggedIn>k__BackingField = value; }
        }

        public StatePrimitive<bool> apiSocketConnected
        {
            [CompilerGenerated]
            get { return <apiSocketConnected>k__BackingField; }
            [CompilerGenerated]
            private set { <apiSocketConnected>k__BackingField = value; }
        }

        public UserState user
        {
            [CompilerGenerated]
            get { return <user>k__BackingField; }
            [CompilerGenerated]
            private set { <user>k__BackingField = value; }
        }

        public NetSessionState netSession
        {
            [CompilerGenerated]
            get { return <netSession>k__BackingField; }
            [CompilerGenerated]
            private set { <netSession>k__BackingField = value; }
        }

        public DebugState debug
        {
            [CompilerGenerated]
            get { return <debug>k__BackingField; }
            [CompilerGenerated]
            private set { <debug>k__BackingField = value; }
        }

        public AppState() : base(null, null)
        {
        }

        public AppState(IStateObservationContext context, IStateTypeIDManifest typeIDManifest) : base(context, typeIDManifest)
        {
        }

        protected override void PostInitialize()
        {
            startupCompleted = CreateStatePrimitive<bool>();
            platform = CreateStatePrimitive<AppPlatform>();
            clientVersion = CreateStatePrimitive<string>();
            clientVersionSHA = CreateStatePrimitive<string>();
            clientUserAgent = CreateStatePrimitive<string>();
            apiOrigin = CreateStatePrimitive<string>();
            apiToken = CreateStatePrimitive<string>();
            isLoggedIn = CreateStatePrimitive<bool>();
            apiSocketConnected = CreateStatePrimitive<bool>();
            user = CreateStateObject<UserState>();
            netSession = CreateStateObject<NetSessionState>();
            debug = CreateStateObject<DebugState>();

            clientUserAgent.RegisterDerivedState(this, <PostInitialize>b__50_0);
        }

        public override void Reset(bool recursively = true)
        {
            base.Reset(recursively);
        }

        [CompilerGenerated]
        private void <PostInitialize>b__50_0(StateChangedEventArgs args)
        {
            if (platform?.value != null && clientVersion?.value != null && clientVersionSHA?.value != null)
            {
                string userAgent = string.Concat(
                    platform.value.ToString(),
                    "/",
                    clientVersion.value,
                    " (",
                    clientVersionSHA.value,
                    ")"
                );
                
                if (clientUserAgent != null)
                {
                    clientUserAgent.value = userAgent;
                }
            }
        }
    }
}