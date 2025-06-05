// Decompiled with Xera AI Decompiler
using System;
using System.Collections.Generic;
using UnityEngine;

namespace AnimalCompany
{
    [RequireComponent(typeof(Collider))]
    public class AnalyticTrigger : MonoBehaviour
    {
        private static Dictionary<string, int> globalEventCount;
        private const string PREFIX = "Trigger: ";
        
        [Header("Events are prefixed with `Trigger: `")]
        public string eventName;
        
        [Tooltip("If true the event will be sent every time the trigger is entered, otherwise it will only be sent once per eventName.")]
        public bool repeatable;
        
        [Header("Debug")]
        [Space]
        public bool setObjectNameToEventName;

        static AnalyticTrigger()
        {
            globalEventCount = new Dictionary<string, int>();
        }

        public AnalyticTrigger()
        {
            repeatable = true;
        }

        private void Start()
        {
            if (string.IsNullOrEmpty(eventName))
            {
                Debug.LogWarning("AnalyticTrigger has no event name set", this);
                enabled = false;
                return;
            }

            if (setObjectNameToEventName)
            {
                gameObject.name = eventName;
            }

            Collider collider = GetComponent<Collider>();
            if (collider != null)
            {
                collider.isTrigger = true;
            }
            else
            {
                Debug.LogWarning("AnalyticTrigger requires a Collider component", this);
                enabled = false;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other == null || !other.CompareTag("Player"))
                return;

            if (!repeatable)
            {
                if (globalEventCount.ContainsKey(eventName))
                    return;
            }

            if (globalEventCount.ContainsKey(eventName))
            {
                globalEventCount[eventName] = globalEventCount[eventName] + 1;
            }
            else
            {
                globalEventCount[eventName] = 1;
            }

            string fullEventName = PREFIX + eventName;
            
            // Send analytics event
            Analytics.Track(fullEventName, new Dictionary<string, object>
            {
                { "count", globalEventCount[eventName] },
                { "repeatable", repeatable }
            });
        }
    }
}