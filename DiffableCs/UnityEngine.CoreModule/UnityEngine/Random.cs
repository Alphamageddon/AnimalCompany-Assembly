namespace UnityEngine;

[NativeHeader("Runtime/Export/Random/Random.bindings.h")]
public static class Random
{
	internal struct State
	{
		[SerializeField]
		private int s0; //Field offset: 0x0
		[SerializeField]
		private int s1; //Field offset: 0x4
		[SerializeField]
		private int s2; //Field offset: 0x8
		[SerializeField]
		private int s3; //Field offset: 0xC

	}


	public static Vector3 insideUnitSphere
	{
		[FreeFunction]
		 get { } //Length: 76
	}

	public static Vector3 onUnitSphere
	{
		[FreeFunction]
		 get { } //Length: 76
	}

	[StaticAccessor("GetScriptingRand()", StaticAccessorType::Dot (0))]
	public static State state
	{
		 get { } //Length: 68
		 set { } //Length: 64
	}

	public static float value
	{
		[FreeFunction]
		 get { } //Length: 40
	}

	public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax) { }

	public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax) { }

	[FreeFunction]
	public static Vector3 get_insideUnitSphere() { }

	private static void get_insideUnitSphere_Injected(out Vector3 ret) { }

	[FreeFunction]
	public static Vector3 get_onUnitSphere() { }

	private static void get_onUnitSphere_Injected(out Vector3 ret) { }

	public static State get_state() { }

	private static void get_state_Injected(out State ret) { }

	[FreeFunction]
	public static float get_value() { }

	[NativeMethod("SetSeed")]
	[StaticAccessor("GetScriptingRand()", StaticAccessorType::Dot (0))]
	public static void InitState(int seed) { }

	[FreeFunction]
	private static int RandomRangeInt(int minInclusive, int maxExclusive) { }

	[FreeFunction]
	public static float Range(float minInclusive, float maxInclusive) { }

	public static int Range(int minInclusive, int maxExclusive) { }

	public static void set_state(State value) { }

	private static void set_state_Injected(ref State value) { }

}

