namespace UnityEngine.InputSystem;

[InputControlLayout(stateType = typeof(TouchscreenState), isGenericTypeOfDevice = True)]
public class Touchscreen : Pointer, IInputStateCallbackReceiver, IEventMerger, ICustomDeviceReset
{
	[CompilerGenerated]
	private static Touchscreen <current>k__BackingField; //Field offset: 0x0
	internal static float s_TapTime; //Field offset: 0x8
	internal static float s_TapDelayTime; //Field offset: 0xC
	internal static float s_TapRadiusSquared; //Field offset: 0x10
	[CompilerGenerated]
	private TouchControl <primaryTouch>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	private ReadOnlyArray<TouchControl> <touches>k__BackingField; //Field offset: 0x1A8

	public internal static Touchscreen current
	{
		[CompilerGenerated]
		 get { } //Length: 72
		[CompilerGenerated]
		internal set { } //Length: 76
	}

	public TouchControl primaryTouch
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	protected TouchControl[] touchControlArray
	{
		 get { } //Length: 8
		 set { } //Length: 116
	}

	public ReadOnlyArray<TouchControl> touches
	{
		[CompilerGenerated]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Touchscreen() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public static Touchscreen get_current() { }

	[CompilerGenerated]
	public TouchControl get_primaryTouch() { }

	protected TouchControl[] get_touchControlArray() { }

	[CompilerGenerated]
	public ReadOnlyArray<TouchControl> get_touches() { }

	public virtual void MakeCurrent() { }

	internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	protected void OnNextUpdate() { }

	protected virtual void OnRemoved() { }

	protected void OnStateEvent(InputEventPtr eventPtr) { }

	[CompilerGenerated]
	internal static void set_current(Touchscreen value) { }

	[CompilerGenerated]
	protected void set_primaryTouch(TouchControl value) { }

	protected void set_touchControlArray(TouchControl[] value) { }

	[CompilerGenerated]
	protected void set_touches(ReadOnlyArray<TouchControl> value) { }

	private static void TriggerTap(TouchControl control, ref TouchState state, InputEventPtr eventPtr) { }

	private override void UnityEngine.InputSystem.LowLevel.ICustomDeviceReset.Reset() { }

	private override bool UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	private override bool UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) { }

	private override void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	private override void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

}

