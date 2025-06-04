namespace UnityEngine;

[NativeHeader("Runtime/Camera/RenderSettings.h")]
[NativeHeader("Runtime/Graphics/QualitySettingsTypes.h")]
[StaticAccessor("GetRenderSettings()", StaticAccessorType::Dot (0))]
public sealed class RenderSettings : object
{

	public static Color ambientEquatorColor
	{
		 get { } //Length: 72
	}

	public static Color ambientGroundColor
	{
		 get { } //Length: 72
	}

	[NativeProperty("AmbientSkyColor")]
	public static Color ambientLight
	{
		 get { } //Length: 72
		 set { } //Length: 68
	}

	public static SphericalHarmonicsL2 ambientProbe
	{
		[NativeMethod("GetFinalAmbientProbe")]
		 get { } //Length: 108
	}

	public static Color ambientSkyColor
	{
		 get { } //Length: 72
	}

	[NativeProperty("UseFog")]
	public static bool fog
	{
		 get { } //Length: 40
	}

	public static Color fogColor
	{
		 get { } //Length: 72
		 set { } //Length: 68
	}

	public static float fogDensity
	{
		 get { } //Length: 40
		 set { } //Length: 56
	}

	public static float reflectionIntensity
	{
		 get { } //Length: 40
	}

	[NativeProperty("SkyboxMaterial")]
	public static Material skybox
	{
		 get { } //Length: 40
		 set { } //Length: 60
	}

	public static Color subtractiveShadowColor
	{
		 get { } //Length: 72
		 set { } //Length: 68
	}

	public static Light sun
	{
		 get { } //Length: 40
	}

	public static Color get_ambientEquatorColor() { }

	private static void get_ambientEquatorColor_Injected(out Color ret) { }

	public static Color get_ambientGroundColor() { }

	private static void get_ambientGroundColor_Injected(out Color ret) { }

	public static Color get_ambientLight() { }

	private static void get_ambientLight_Injected(out Color ret) { }

	[NativeMethod("GetFinalAmbientProbe")]
	public static SphericalHarmonicsL2 get_ambientProbe() { }

	private static void get_ambientProbe_Injected(out SphericalHarmonicsL2 ret) { }

	public static Color get_ambientSkyColor() { }

	private static void get_ambientSkyColor_Injected(out Color ret) { }

	public static bool get_fog() { }

	public static Color get_fogColor() { }

	private static void get_fogColor_Injected(out Color ret) { }

	public static float get_fogDensity() { }

	public static float get_reflectionIntensity() { }

	public static Material get_skybox() { }

	public static Color get_subtractiveShadowColor() { }

	private static void get_subtractiveShadowColor_Injected(out Color ret) { }

	public static Light get_sun() { }

	public static void set_ambientLight(Color value) { }

	private static void set_ambientLight_Injected(ref Color value) { }

	public static void set_fogColor(Color value) { }

	private static void set_fogColor_Injected(ref Color value) { }

	public static void set_fogDensity(float value) { }

	public static void set_skybox(Material value) { }

	public static void set_subtractiveShadowColor(Color value) { }

	private static void set_subtractiveShadowColor_Injected(ref Color value) { }

}

