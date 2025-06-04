namespace Fusion;

public abstract class FusionGlobalScriptableObject : FusionGlobalScriptableObject
{
	private static T s_instance; //Field offset: 0x0
	private static FusionGlobalScriptableObjectUnloadDelegate s_unloadHandler; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsGlobal>k__BackingField; //Field offset: 0x0

	protected static T GlobalInternal
	{
		 get { } //Length: 224
		 set { } //Length: 196
	}

	public private bool IsGlobal
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	protected static bool IsGlobalLoadedInternal
	{
		 get { } //Length: 140
	}

	private static string LogPrefix
	{
		private get { } //Length: 200
	}

	protected FusionGlobalScriptableObject`1() { }

	private static string AsId(FusionGlobalScriptableObject<T> obj) { }

	protected static T get_GlobalInternal() { }

	[CompilerGenerated]
	public bool get_IsGlobal() { }

	protected static bool get_IsGlobalLoadedInternal() { }

	private static string get_LogPrefix() { }

	private static T GetOrLoadGlobalInstance() { }

	private static T LoadPlayerInstance(out FusionGlobalScriptableObjectUnloadDelegate unloadHandler) { }

	protected override void OnDisable() { }

	protected override void OnLoadedAsGlobal() { }

	protected override void OnUnloadedAsGlobal(bool destroyed) { }

	protected static void set_GlobalInternal(T value) { }

	[CompilerGenerated]
	private void set_IsGlobal(bool value) { }

	private static void SetGlobalInternal(T value, FusionGlobalScriptableObjectUnloadDelegate unloadHandler) { }

	protected static bool TryGetGlobalInternal(out T global) { }

	protected static bool UnloadGlobalInternal() { }

}

