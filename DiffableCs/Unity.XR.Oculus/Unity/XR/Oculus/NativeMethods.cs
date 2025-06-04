namespace Unity.XR.Oculus;

public static class NativeMethods
{
	private static class Internal
	{

		internal static void EnableAppMetrics(bool enable) { }

		internal static void EnablePerfMetrics(bool enable) { }

		internal static bool GetAppHasInputFocus() { }

		internal static bool GetAppShouldQuit() { }

		internal static bool GetBoundaryConfigured() { }

		internal static bool GetBoundaryDimensions(BoundaryType boundaryType, out Vector3 dimensions) { }

		internal static bool GetBoundaryVisible() { }

		internal static bool GetDisplayAvailableFrequencies(IntPtr ptr, ref int numFrequencies) { }

		internal static bool GetDisplayFrequency(out float refreshRate) { }

		internal static bool GetEyeTrackedFoveatedRenderingEnabled() { }

		internal static bool GetEyeTrackedFoveatedRenderingSupported() { }

		internal static bool GetIsSupportedDevice() { }

		internal static void GetOVRPVersion(Byte[] version) { }

		internal static bool GetShouldRestartSession() { }

		internal static SystemHeadset GetSystemHeadsetType() { }

		internal static int GetTiledMultiResLevel() { }

		internal static bool GetTiledMultiResSupported() { }

		internal static bool LoadOVRPlugin(string ovrpPath) { }

		internal static void SetBoundaryVisible(bool boundaryVisible) { }

		internal static void SetColorOffset(float x, float y, float z, float w) { }

		internal static void SetColorScale(float x, float y, float z, float w) { }

		internal static int SetCPULevel(int cpuLevel) { }

		internal static bool SetDeveloperModeStrict(bool active) { }

		internal static bool SetDisplayFrequency(float refreshRate) { }

		internal static void SetEyeTrackedFoveatedRenderingEnabled(bool isEnabled) { }

		internal static int SetGPULevel(int gpuLevel) { }

		internal static void SetTiledMultiResDynamic(bool isDynamic) { }

		internal static void SetTiledMultiResLevel(int level) { }

		internal static void SetUserDefinedSettings(UserDefinedSettings settings) { }

		internal static void UnloadOVRPlugin() { }

	}

	public struct UserDefinedSettings
	{
		public ushort sharedDepthBuffer; //Field offset: 0x0
		public ushort dashSupport; //Field offset: 0x2
		public ushort stereoRenderingMode; //Field offset: 0x4
		public ushort colorSpace; //Field offset: 0x6
		public ushort lowOverheadMode; //Field offset: 0x8
		public ushort optimizeBufferDiscards; //Field offset: 0xA
		public ushort phaseSync; //Field offset: 0xC
		public ushort symmetricProjection; //Field offset: 0xE
		public ushort subsampledLayout; //Field offset: 0x10
		public ushort lateLatching; //Field offset: 0x12
		public ushort lateLatchingDebug; //Field offset: 0x14
		public ushort enableTrackingOriginStageMode; //Field offset: 0x16
		public ushort spaceWarp; //Field offset: 0x18
		public ushort depthSubmission; //Field offset: 0x1A
		public ushort foveatedRenderingMethod; //Field offset: 0x1C

	}


	internal static void EnableAppMetrics(bool enable) { }

	internal static void EnablePerfMetrics(bool enable) { }

	internal static bool GetAppShouldQuit() { }

	internal static bool GetBoundaryConfigured() { }

	internal static bool GetBoundaryDimensions(BoundaryType boundaryType, out Vector3 dimensions) { }

	internal static bool GetBoundaryVisible() { }

	internal static bool GetDisplayAvailableFrequencies(IntPtr ptr, ref int numFrequencies) { }

	internal static bool GetDisplayFrequency(out float refreshRate) { }

	internal static bool GetEyeTrackedFoveatedRenderingEnabled() { }

	internal static bool GetEyeTrackedFoveatedRenderingSupported() { }

	internal static bool GetHasInputFocus() { }

	internal static bool GetIsSupportedDevice() { }

	internal static void GetOVRPVersion(Byte[] version) { }

	internal static bool GetShouldRestartSession() { }

	internal static SystemHeadset GetSystemHeadsetType() { }

	internal static int GetTiledMultiResLevel() { }

	internal static bool GetTiledMultiResSupported() { }

	internal static bool LoadOVRPlugin(string ovrpPath) { }

	internal static void SetBoundaryVisible(bool boundaryVisible) { }

	internal static void SetColorOffset(float x, float y, float z, float w) { }

	internal static void SetColorScale(float x, float y, float z, float w) { }

	internal static int SetCPULevel(int cpuLevel) { }

	internal static bool SetDeveloperModeStrict(bool active) { }

	internal static bool SetDisplayFrequency(float refreshRate) { }

	internal static void SetEyeTrackedFoveatedRenderingEnabled(bool isEnabled) { }

	internal static int SetGPULevel(int gpuLevel) { }

	internal static void SetTiledMultiResDynamic(bool isDynamic) { }

	internal static void SetTiledMultiResLevel(int level) { }

	internal static void SetUserDefinedSettings(UserDefinedSettings settings) { }

	internal static void UnloadOVRPlugin() { }

}

