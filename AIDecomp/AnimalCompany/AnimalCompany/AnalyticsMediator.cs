// Decompiled with Xera AI Decompiler
using UnityEngine;
using SpatialSys.ObservableState;

namespace AnimalCompany
{
    public class AnalyticsMediator : MonoBehaviour
    {
        private ObserverDelegate<StateChangedEventArgs> analyticsObserver;

        public AnalyticsMediator()
        {
        }

        private void Awake()
        {
            // Initialize analytics observer
            analyticsObserver = new ObserverDelegate<StateChangedEventArgs>(this, HandleAnalyticsAppStateChanged);
            
            // Register observer with the app state system
            App.RegisterObserver(analyticsObserver);
        }

        private void HandleAnalyticsAppStateChanged(StateChangedEventArgs args)
        {
            // Handle analytics state changes
            if (args != null)
            {
                Analytics.Register(args.StateName);
            }
        }

        private void OnDestroy()
        {
            // Deregister observer when component is destroyed
            if (analyticsObserver != null)
            {
                App.DeregisterObserver(analyticsObserver);
            }
        }
    }
}