namespace UnityEngine;

[NativeHeader("Runtime/Input/TimeManager.h")]
[StaticAccessor("GetTimeManager()", StaticAccessorType::Dot (0))]
public class Time
{

	public static float deltaTime
	{
		 get { } //Length: 40
	}

	public static float fixedDeltaTime
	{
		 get { } //Length: 40
		 set { } //Length: 56
	}

	public static float fixedTime
	{
		 get { } //Length: 40
	}

	public static float fixedUnscaledTime
	{
		 get { } //Length: 40
	}

	public static int frameCount
	{
		 get { } //Length: 40
	}

	[NativeProperty("Realtime")]
	public static float realtimeSinceStartup
	{
		 get { } //Length: 40
	}

	[NativeProperty("RenderFrameCount")]
	public static int renderedFrameCount
	{
		 get { } //Length: 40
	}

	public static float smoothDeltaTime
	{
		 get { } //Length: 40
	}

	[NativeProperty("CurTime")]
	public static float time
	{
		 get { } //Length: 40
	}

	[NativeProperty("CurTime")]
	public static double timeAsDouble
	{
		 get { } //Length: 40
	}

	public static float timeScale
	{
		 get { } //Length: 40
	}

	public static float unscaledDeltaTime
	{
		 get { } //Length: 40
	}

	public static float unscaledTime
	{
		 get { } //Length: 40
	}

	public static float get_deltaTime() { }

	public static float get_fixedDeltaTime() { }

	public static float get_fixedTime() { }

	public static float get_fixedUnscaledTime() { }

	public static int get_frameCount() { }

	public static float get_realtimeSinceStartup() { }

	public static int get_renderedFrameCount() { }

	public static float get_smoothDeltaTime() { }

	public static float get_time() { }

	public static double get_timeAsDouble() { }

	public static float get_timeScale() { }

	public static float get_unscaledDeltaTime() { }

	public static float get_unscaledTime() { }

	public static void set_fixedDeltaTime(float value) { }

}

