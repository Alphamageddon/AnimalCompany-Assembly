namespace Unity.XR.Oculus;

public class Stats
{
	internal static class AdaptivePerformance
	{

		public static float AdaptivePerformanceScale
		{
			 get { } //Length: 124
		}

		public static float BatteryLevel
		{
			 get { } //Length: 124
		}

		public static float BatteryTemp
		{
			 get { } //Length: 124
		}

		public static int CPULevel
		{
			 get { } //Length: 148
		}

		public static float GPUAppTime
		{
			 get { } //Length: 176
		}

		public static float GPUCompositorTime
		{
			 get { } //Length: 176
		}

		public static int GPULevel
		{
			 get { } //Length: 148
		}

		public static float MotionToPhoton
		{
			 get { } //Length: 176
		}

		public static bool PowerSavingMode
		{
			 get { } //Length: 132
		}

		[Obsolete("RefreshRate is deprecated. Use Performance.TryGetDisplayRefreshRate instead.", False)]
		public static float RefreshRate
		{
			 get { } //Length: 176
		}

		public static float get_AdaptivePerformanceScale() { }

		public static float get_BatteryLevel() { }

		public static float get_BatteryTemp() { }

		public static int get_CPULevel() { }

		public static float get_GPUAppTime() { }

		public static float get_GPUCompositorTime() { }

		public static int get_GPULevel() { }

		public static float get_MotionToPhoton() { }

		public static bool get_PowerSavingMode() { }

		public static float get_RefreshRate() { }

	}

	internal static class AppMetrics
	{

		public static float AppCPUElapsedTime
		{
			 get { } //Length: 124
		}

		public static float AppQueueAheadTime
		{
			 get { } //Length: 124
		}

		public static float CompositorCPUTime
		{
			 get { } //Length: 124
		}

		public static float CompositorDroppedFrames
		{
			 get { } //Length: 124
		}

		public static float CompositorLatency
		{
			 get { } //Length: 124
		}

		public static float CPUStartToGPUEnd
		{
			 get { } //Length: 124
		}

		public static float GPUEndToVsync
		{
			 get { } //Length: 124
		}

		public static void EnableAppMetrics(bool enable) { }

		public static float get_AppCPUElapsedTime() { }

		public static float get_AppQueueAheadTime() { }

		public static float get_CompositorCPUTime() { }

		public static float get_CompositorDroppedFrames() { }

		public static float get_CompositorLatency() { }

		public static float get_CPUStartToGPUEnd() { }

		public static float get_GPUEndToVsync() { }

	}

	internal static class PerfMetrics
	{

		public static float AppCPUTime
		{
			 get { } //Length: 124
		}

		public static float AppGPUTime
		{
			 get { } //Length: 124
		}

		public static float CompositorCPUTime
		{
			 get { } //Length: 124
		}

		public static float CompositorGPUTime
		{
			 get { } //Length: 124
		}

		public static float CPUClockFrequency
		{
			 get { } //Length: 124
		}

		public static float CPUUtilizationAverage
		{
			 get { } //Length: 124
		}

		public static float CPUUtilizationWorst
		{
			 get { } //Length: 124
		}

		public static float GPUClockFrequency
		{
			 get { } //Length: 124
		}

		public static float GPUUtilization
		{
			 get { } //Length: 124
		}

		public static void EnablePerfMetrics(bool enable) { }

		public static float get_AppCPUTime() { }

		public static float get_AppGPUTime() { }

		public static float get_CompositorCPUTime() { }

		public static float get_CompositorGPUTime() { }

		public static float get_CPUClockFrequency() { }

		public static float get_CPUUtilizationAverage() { }

		public static float get_CPUUtilizationWorst() { }

		public static float get_GPUClockFrequency() { }

		public static float get_GPUUtilization() { }

	}

	private static IntegratedSubsystem m_Display; //Field offset: 0x0
	private static string m_PluginVersion; //Field offset: 0x8

	public static string PluginVersion
	{
		 get { } //Length: 332
	}

	private static Stats() { }

	public Stats() { }

	public static string get_PluginVersion() { }

	private static IntegratedSubsystem GetOculusDisplaySubsystem() { }

}

