using System;
using System.Runtime.CompilerServices;

namespace AnimalCompany
{
    public class AppStartupCompletedAction : BaseSetAction<bool>
    {
        [CompilerGenerated]
        private sealed class <>c
        {
            public static readonly <>c <>9 = new <>c();
            public static Func<AppState, StatePrimitive<bool>> <>9__0_0;

            static <>c()
            {
            }

            public <>c()
            {
            }

            internal StatePrimitive<bool> <.ctor>b__0_0(AppState state)
            {
                return state.AppStartupCompleted;
            }
        }

        public AppStartupCompletedAction(bool value) : base(value, <>c.<>9__0_0 ?? (<>c.<>9__0_0 = new Func<AppState, StatePrimitive<bool>>(<>c.<>9.<.ctor>b__0_0)))
        {
        }
    }
}