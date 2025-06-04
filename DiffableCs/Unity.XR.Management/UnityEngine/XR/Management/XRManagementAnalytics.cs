namespace UnityEngine.XR.Management;

internal static class XRManagementAnalytics
{
	private struct BuildEvent
	{
		public string buildGuid; //Field offset: 0x0
		public string buildTarget; //Field offset: 0x8
		public string buildTargetGroup; //Field offset: 0x10
		public String[] assigned_loaders; //Field offset: 0x18

	}

	private const int kMaxEventsPerHour = 1000; //Field offset: 0x0
	private const int kMaxNumberOfElements = 1000; //Field offset: 0x0
	private const string kVendorKey = "unity.xrmanagement"; //Field offset: 0x0
	private const string kEventBuild = "xrmanagment_build"; //Field offset: 0x0
	private static bool s_Initialized; //Field offset: 0x0

	private static bool Initialize() { }

}

