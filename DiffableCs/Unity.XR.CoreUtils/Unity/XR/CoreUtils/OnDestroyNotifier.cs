namespace Unity.XR.CoreUtils;

[AddComponentMenu(null)]
[ExecuteInEditMode]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.core-utils@2.0/api/Unity.XR.CoreUtils.OnDestroyNotifier.html")]
public class OnDestroyNotifier : MonoBehaviour
{
	[CompilerGenerated]
	private Action<OnDestroyNotifier> <Destroyed>k__BackingField; //Field offset: 0x20

	public private Action<OnDestroyNotifier> Destroyed
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public OnDestroyNotifier() { }

	[CompilerGenerated]
	private Action<OnDestroyNotifier> get_Destroyed() { }

	private void OnDestroy() { }

	[CompilerGenerated]
	public void set_Destroyed(Action<OnDestroyNotifier> value) { }

}

