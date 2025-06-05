// Decompiled with Xera AI Decompiler
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AnimalCompany.Logging
{
    public class ChannelLogger : ILogger
    {
        [CompilerGenerated]
        private LogChannel <logChannel>k__BackingField;

        public LogChannel logChannel
        {
            [CompilerGenerated]
            get { return <logChannel>k__BackingField; }
            [CompilerGenerated]
            private set { <logChannel>k__BackingField = value; }
        }

        public ChannelLogger(LogChannel logChannel)
        {
            this.logChannel = logChannel;
        }

        private LogLevel ConvertLogLevel(LogLevel level)
        {
            return level;
        }

        public override bool IsEnabled(LogLevel level)
        {
            return Log.IsEnabled(ConvertLogLevel(level), logChannel);
        }

        public override void Trace(string message, Dictionary<string, object> data = null, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = -1)
        {
            Log.Trace(logChannel, message, data, filePath, memberName, lineNumber);
        }

        public override void Debug(string message, Dictionary<string, object> data = null, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = -1)
        {
            Log.Debug(logChannel, message, data, filePath, memberName, lineNumber);
        }

        public override void Info(string message, Dictionary<string, object> data = null, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = -1)
        {
            Log.Info(logChannel, message, data, filePath, memberName, lineNumber);
        }

        public override void Warning(string message, Dictionary<string, object> data = null, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = -1)
        {
            Log.Warning(logChannel, message, data, filePath, memberName, lineNumber);
        }

        public override void Error(string message, Dictionary<string, object> data = null, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = -1)
        {
            Log.Error(logChannel, message, data, filePath, memberName, lineNumber);
        }

        public override void Error(string message, Exception exception, Dictionary<string, object> data = null, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = -1)
        {
            Log.Error(logChannel, message, exception, data, filePath, memberName, lineNumber);
        }

        public override void Error(Exception exception, Dictionary<string, object> data = null, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = -1)
        {
            Log.Error(logChannel, exception, data, filePath, memberName, lineNumber);
        }

        public override void Generic(LogLevel level, string message, Exception exception = null, Dictionary<string, object> data = null, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = -1)
        {
            Log.Generic(ConvertLogLevel(level), logChannel, message, exception, data, filePath, memberName, lineNumber);
        }

        [CompilerGenerated]
        public LogChannel get_logChannel()
        {
            return <logChannel>k__BackingField;
        }

        [CompilerGenerated]
        private void set_logChannel(LogChannel value)
        {
            <logChannel>k__BackingField = value;
        }
    }
}