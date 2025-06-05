// Decompiled with Xera AI Decompiler
using System.Runtime.CompilerServices;
using SpatialSys.ObservableState;

namespace AnimalCompany
{
    public class DebugState : StateObject
    {
        public const string PLAYER_PREFS_LOCAL_LOG_LEVEL = "DebugLocalLogLevel";
        public const string PLAYER_PREFS_REMOTE_LOG_LEVEL = "DebugRemoteLogLevel";

        [CompilerGenerated]
        private StatePrimitive<LogLevel> <logLevel>k__BackingField;

        [CompilerGenerated]
        private StatePrimitive<LogChannel> <logChannelFlags>k__BackingField;

        [CompilerGenerated]
        private StatePrimitive<LogLevel> <remoteLogLevel>k__BackingField;

        [CompilerGenerated]
        private StatePrimitive<LogChannel> <remoteLogChannelFlags>k__BackingField;

        public StatePrimitive<LogLevel> logLevel
        {
            [CompilerGenerated]
            get { return <logLevel>k__BackingField; }
            [CompilerGenerated]
            private set { <logLevel>k__BackingField = value; }
        }

        public StatePrimitive<LogChannel> logChannelFlags
        {
            [CompilerGenerated]
            get { return <logChannelFlags>k__BackingField; }
            [CompilerGenerated]
            private set { <logChannelFlags>k__BackingField = value; }
        }

        public StatePrimitive<LogLevel> remoteLogLevel
        {
            [CompilerGenerated]
            get { return <remoteLogLevel>k__BackingField; }
            [CompilerGenerated]
            private set { <remoteLogLevel>k__BackingField = value; }
        }

        public StatePrimitive<LogChannel> remoteLogChannelFlags
        {
            [CompilerGenerated]
            get { return <remoteLogChannelFlags>k__BackingField; }
            [CompilerGenerated]
            private set { <remoteLogChannelFlags>k__BackingField = value; }
        }

        public DebugState()
        {
        }
    }
}