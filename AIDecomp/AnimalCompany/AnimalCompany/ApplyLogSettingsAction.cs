// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    public class ApplyLogSettingsAction : BaseAction
    {
        private LogLevel _logLevel;
        private LogChannel _logChannelFlags;
        private LogLevel _remoteLogLevel;
        private LogChannel _remoteLogChannelFlags;

        public ApplyLogSettingsAction(LogLevel logLevel, LogChannel logChannelFlags, LogLevel remoteLogLevel, LogChannel remoteLogChannelFlags)
        {
            _logLevel = logLevel;
            _logChannelFlags = logChannelFlags;
            _remoteLogLevel = remoteLogLevel;
            _remoteLogChannelFlags = remoteLogChannelFlags;
        }

        public override void Execute(AppState state)
        {
            if (state?.LoggingState?.LocalLogLevel != null)
            {
                state.LoggingState.LocalLogLevel.Value = _logLevel;
            }

            if (state?.LoggingState?.LocalLogChannelFlags != null)
            {
                state.LoggingState.LocalLogChannelFlags.Value = _logChannelFlags;
            }

            if (state?.LoggingState?.RemoteLogLevel != null)
            {
                state.LoggingState.RemoteLogLevel.Value = _remoteLogLevel;
            }

            if (state?.LoggingState?.RemoteLogChannelFlags != null)
            {
                state.LoggingState.RemoteLogChannelFlags.Value = _remoteLogChannelFlags;
            }
        }
    }
}