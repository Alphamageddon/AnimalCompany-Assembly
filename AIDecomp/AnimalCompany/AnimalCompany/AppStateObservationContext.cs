using SpatialSys.ObservableState;

namespace AnimalCompany
{
    public class AppStateObservationContext : StateObservationContext
    {
        public AppStateObservationContext() : base(CreateDefaultTypeIDManifest(), CreateDefaultLogger())
        {
        }

        public AppStateObservationContext(IStateTypeIDManifest typeIDManifest) : base(typeIDManifest, CreateDefaultLogger())
        {
        }

        public AppStateObservationContext(ILogger logger) : base(CreateDefaultTypeIDManifest(), logger)
        {
        }

        public AppStateObservationContext(IStateTypeIDManifest typeIDManifest, ILogger logger) : base(typeIDManifest, logger)
        {
        }

        private static IStateTypeIDManifest CreateDefaultTypeIDManifest()
        {
            return new AutoRegisteredTypeIDManifest(typeof(AppStateObservationContext));
        }

        private static ILogger CreateDefaultLogger()
        {
            return new ChannelLogger(128);
        }
    }
}