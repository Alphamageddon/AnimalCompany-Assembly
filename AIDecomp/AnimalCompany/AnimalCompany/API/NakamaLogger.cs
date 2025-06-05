// Decompiled with Xera AI Decompiler
using System;
using UnityEngine;

namespace AnimalCompany.API
{
    public class NakamaLogger : ILogger
    {
        private LogChannel _channel;

        public NakamaLogger(LogChannel channel)
        {
            _channel = channel;
        }

        public override void DebugFormat(string format, params object[] args)
        {
            string message = string.Format(format, args);
            Log.Debug((int)_channel, message, null, null, null, 15);
        }

        public override void ErrorFormat(string format, params object[] args)
        {
            string message = string.Format(format, args);
            Log.Error((int)_channel, message, null, null, null, 20);
        }

        public override void InfoFormat(string format, params object[] args)
        {
            string message = string.Format(format, args);
            Log.Info((int)_channel, message, null, null, null, 25);
        }

        public override void WarnFormat(string format, params object[] args)
        {
            string message = string.Format(format, args);
            Log.Warning((int)_channel, message, null, null, null, 30);
        }
    }
}