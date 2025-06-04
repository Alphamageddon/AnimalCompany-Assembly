namespace AnimalCompany;

public static class Analytics
{
        private static bool ANALYTICS_ENABLED; //Field offset: 0x0

        static Analytics()
        {
                ANALYTICS_ENABLED = true;
                mixpanel.Mixpanel.Init();
        }

        private static Value ObjectsToValue(Dictionary<String, Object> dict)
        {
                var value = new Value();
                if (dict == null)
                        return value;

                foreach (var kvp in dict)
                {
                        value.set_Item(kvp.Key, ObjectToValue(kvp.Value));
                }
                return value;
        }

        private static Value ObjectsToValue(ValueTuple<String, Object>[] objects)
        {
                var value = new Value();
                if (objects == null)
                        return value;

                foreach (var pair in objects)
                {
                        value.set_Item(pair.Item1, ObjectToValue(pair.Item2));
                }
                return value;
        }

        private static Value ObjectToValue(object obj)
        {
                if (obj is Value v)
                        return v;
                return mixpanel.Value.op_Implicit(obj);
        }

        public static void Register(string propertyName, object propertyValue)
        {
                if (!ANALYTICS_ENABLED) return;
                mixpanel.Mixpanel.Register(propertyName, ObjectToValue(propertyValue));
        }

        public static void Track(string eventName)
        {
                if (!ANALYTICS_ENABLED) return;
                mixpanel.Mixpanel.Track(eventName);
        }

        public static void Track(string eventName, Dictionary<String, Object> properties)
        {
                if (!ANALYTICS_ENABLED) return;
                mixpanel.Mixpanel.Track(eventName, ObjectsToValue(properties));
        }

        public static void Track(string eventName, ValueTuple<String, Object>[] properties)
        {
                if (!ANALYTICS_ENABLED) return;
                mixpanel.Mixpanel.Track(eventName, ObjectsToValue(properties));
        }

        public static void Track(string eventName, string propertyName, object propertyValue)
        {
                if (!ANALYTICS_ENABLED) return;
                mixpanel.Mixpanel.Track(eventName, propertyName, ObjectToValue(propertyValue));
        }

}

