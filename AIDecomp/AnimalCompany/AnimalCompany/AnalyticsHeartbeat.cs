using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AnimalCompany
{
    public class AnalyticsHeartbeat : MonoBehaviour
    {
        [CompilerGenerated]
        private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, System.IDisposable
        {
            private int <>1__state;
            private object <>2__current;

            object IEnumerator<object>.Current
            {
                [DebuggerHidden]
                get { return <>2__current; }
            }

            object IEnumerator.Current
            {
                [DebuggerHidden]
                get { return <>2__current; }
            }

            [DebuggerHidden]
            public <Start>d__1(int <>1__state)
            {
                this.<>1__state = <>1__state;
            }

            bool IEnumerator.MoveNext()
            {
                switch (<>1__state)
                {
                    case 0:
                        <>1__state = -1;
                        goto case 1;
                    case 1:
                        <>2__current = new WaitForSeconds(60f);
                        <>1__state = 2;
                        return true;
                    case 2:
                        <>1__state = 1;
                        Analytics.CustomEvent("heartbeat");
                        goto case 1;
                    default:
                        return false;
                }
            }

            [DebuggerHidden]
            void IEnumerator.Reset()
            {
                throw new System.NotSupportedException();
            }

            [DebuggerHidden]
            void System.IDisposable.Dispose()
            {
            }
        }

        private const float INTERVAL_SECONDS = 60f;

        public AnalyticsHeartbeat()
        {
        }

        [IteratorStateMachine(typeof(<Start>d__1))]
        private IEnumerator Start()
        {
            return new <Start>d__1(0);
        }
    }
}