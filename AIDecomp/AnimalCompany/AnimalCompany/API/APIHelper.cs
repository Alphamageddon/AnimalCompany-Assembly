// Decompiled with Xera AI Decompiler
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace AnimalCompany.API
{
    public static class APIHelper
    {
        [CompilerGenerated]
        private sealed class <>c
        {
            public static readonly <>c <>9 = new <>c();

            static <>c()
            {
            }

            public <>c()
            {
            }

            internal AppPlatform <.cctor>b__0_0(KeyValuePair<string, AppPlatform> kv)
            {
                return kv.Value;
            }

            internal string <.cctor>b__0_1(KeyValuePair<string, AppPlatform> kv)
            {
                return kv.Key;
            }
        }

        private static Dictionary<string, AppPlatform> _apiToClientPlatformTypeLookup;
        private static Dictionary<AppPlatform, string> _clientToAPIPlatformTypeLookup;

        static APIHelper()
        {
            _apiToClientPlatformTypeLookup = new Dictionary<string, AppPlatform>
            {
                { "ios", AppPlatform.iOS },
                { "android", AppPlatform.Android },
                { "web", AppPlatform.Web },
                { "desktop", AppPlatform.Desktop }
            };

            _clientToAPIPlatformTypeLookup = _apiToClientPlatformTypeLookup.ToDictionary(
                <>c.<>9.<.cctor>b__0_0,
                <>c.<>9.<.cctor>b__0_1
            );
        }

        public static AppPlatform FromAPIClientPlatform(string apiClientPlatform)
        {
            if (string.IsNullOrEmpty(apiClientPlatform))
            {
                return AppPlatform.Unknown;
            }

            if (_apiToClientPlatformTypeLookup.TryGetValue(apiClientPlatform, out AppPlatform platform))
            {
                return platform;
            }

            UnityEngine.Debug.LogError($"Unknown API client platform: {apiClientPlatform}");
            return AppPlatform.Unknown;
        }

        public static string ToAPIPlatform(AppPlatform platform)
        {
            if (_clientToAPIPlatformTypeLookup.TryGetValue(platform, out string apiPlatform))
            {
                return apiPlatform;
            }

            throw new KeyNotFoundException($"Unknown platform: {Enum.GetName(typeof(AppPlatform), platform)}");
        }
    }
}