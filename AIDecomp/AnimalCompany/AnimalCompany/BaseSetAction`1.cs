// Decompiled with Xera AI Decompiler
using System;
using SpatialSys.ObservableState;

namespace AnimalCompany
{
    public abstract class BaseSetAction<T> : BaseAction
    {
        private Func<AppState, StatePrimitive<T>> _filter;
        private T _value;

        public BaseSetAction(Func<AppState, StatePrimitive<T>> filter, T value)
        {
            _filter = filter;
            _value = value;
        }

        public override void Execute(AppState state)
        {
            if (_filter != null)
            {
                var primitive = _filter(state);
                if (primitive != null)
                {
                    primitive.Value = _value;
                }
            }
        }

        public override string ToString()
        {
            if (this == null)
                return null;
                
            string typeName = GetTypeNameStripped();
            string valueString = _value?.ToString() ?? "null";
            return string.Format("{0}: {1}", typeName, valueString);
        }
    }
}