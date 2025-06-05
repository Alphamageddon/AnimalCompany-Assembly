// Decompiled with Xera AI Decompiler
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace AnimalCompany
{
    public class Countdown : MonoBehaviour
    {
        [CompilerGenerated]
        private sealed class <CountdownTimer>d__9 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int <>1__state;
            private object <>2__current;
            public Countdown <>4__this;

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
            public <CountdownTimer>d__9(int <>1__state)
            {
                this.<>1__state = <>1__state;
            }

            bool IEnumerator.MoveNext()
            {
                int state = this.<>1__state;
                Countdown countdown = this.<>4__this;
                
                switch (state)
                {
                    default:
                        return false;
                    case 0:
                        this.<>1__state = -1;
                        goto IL_LOOP;
                    case 1:
                        this.<>1__state = -1;
                        goto IL_LOOP;
                }

                IL_LOOP:
                if (!countdown.TryGetNextDay())
                {
                    return false;
                }

                TimeSpan timeRemaining = countdown._nextDayUTC - DateTime.UtcNow;
                
                if (timeRemaining.TotalSeconds > 0)
                {
                    string timeText = string.Format("{0:D2}:{1:D2}:{2:D2}:{3:D2}",
                        timeRemaining.Days,
                        timeRemaining.Hours,
                        timeRemaining.Minutes,
                        timeRemaining.Seconds);
                    
                    countdown._textTMPUGUI.text = timeText;
                }
                else
                {
                    countdown._textTMPUGUI.text = "00:00:00:00";
                }

                this.<>2__current = countdown.waitForSecond;
                this.<>1__state = 1;
                return true;
            }

            [DebuggerHidden]
            void IEnumerator.Reset()
            {
                throw new NotSupportedException();
            }

            [DebuggerHidden]
            void IDisposable.Dispose()
            {
            }
        }

        private const int HOUR_OFFSET_EDT_TO_UTC = 4;

        [Header("Countdown Timer (EST)")]
        [SerializeField]
        private DayOfWeek _dayOfWeek;
        [SerializeField]
        private int _hourEDT;

        [Header("Reference")]
        [SerializeField]
        private TextMeshProUGUI _textTMPUGUI;

        private WaitForSeconds waitForSecond;
        private DateTime _nextDayUTC;

        public Countdown()
        {
        }

        private void Awake()
        {
            waitForSecond = new WaitForSeconds(1f);
            TryGetNextDay();
            StartCoroutine(CountdownTimer());
        }

        [IteratorStateMachine(typeof(<CountdownTimer>d__9))]
        private IEnumerator CountdownTimer()
        {
            return new <CountdownTimer>d__9(0)
            {
                <>4__this = this
            };
        }

        private TimeZoneInfo GetEasternTimeZoneInfo()
        {
            try
            {
                return TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            }
            catch
            {
                try
                {
                    return TimeZoneInfo.FindSystemTimeZoneById("America/New_York");
                }
                catch
                {
                    return TimeZoneInfo.Utc;
                }
            }
        }

        private bool TryGetNextDay()
        {
            DateTime utcNow = DateTime.UtcNow;
            DayOfWeek currentDayOfWeek = utcNow.DayOfWeek;
            
            int daysUntilTarget = ((int)_dayOfWeek - (int)currentDayOfWeek + 7) % 7;
            if (daysUntilTarget == 0)
            {
                daysUntilTarget = 7;
            }

            DateTime targetDate = new DateTime(utcNow.Year, utcNow.Month, utcNow.Day, _hourEDT + HOUR_OFFSET_EDT_TO_UTC, 0, 0, DateTimeKind.Utc);
            _nextDayUTC = targetDate.AddDays(daysUntilTarget);

            return true;
        }
    }
}