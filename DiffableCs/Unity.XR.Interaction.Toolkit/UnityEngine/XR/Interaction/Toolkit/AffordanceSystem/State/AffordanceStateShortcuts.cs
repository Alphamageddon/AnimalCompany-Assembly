namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.State;

public static class AffordanceStateShortcuts
{
	public const byte disabled = 0; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly AffordanceStateData <disabledState>k__BackingField; //Field offset: 0x0
	public const byte idle = 1; //Field offset: 0x0
	public const byte hovered = 2; //Field offset: 0x0
	public const byte hoveredPriority = 3; //Field offset: 0x0
	public const byte selected = 4; //Field offset: 0x0
	public const byte activated = 5; //Field offset: 0x0
	public const byte focused = 6; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly AffordanceStateData <idleState>k__BackingField; //Field offset: 0x2
	[CompilerGenerated]
	private static readonly AffordanceStateData <hoveredState>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private static readonly AffordanceStateData <hoveredPriorityState>k__BackingField; //Field offset: 0x6
	[CompilerGenerated]
	private static readonly AffordanceStateData <selectedState>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private static readonly AffordanceStateData <activatedState>k__BackingField; //Field offset: 0xA
	[CompilerGenerated]
	private static readonly AffordanceStateData <focusedState>k__BackingField; //Field offset: 0xC
	private static readonly Dictionary<Byte, String> k_StateNames; //Field offset: 0x10
	[CompilerGenerated]
	private static readonly byte <stateCount>k__BackingField; //Field offset: 0x18

	public static AffordanceStateData activatedState
	{
		[CompilerGenerated]
		 get { } //Length: 88
	}

	public static AffordanceStateData disabledState
	{
		[CompilerGenerated]
		 get { } //Length: 88
	}

	public static AffordanceStateData focusedState
	{
		[CompilerGenerated]
		 get { } //Length: 88
	}

	public static AffordanceStateData hoveredPriorityState
	{
		[CompilerGenerated]
		 get { } //Length: 88
	}

	public static AffordanceStateData hoveredState
	{
		[CompilerGenerated]
		 get { } //Length: 88
	}

	public static AffordanceStateData idleState
	{
		[CompilerGenerated]
		 get { } //Length: 88
	}

	public static AffordanceStateData selectedState
	{
		[CompilerGenerated]
		 get { } //Length: 88
	}

	internal static byte stateCount
	{
		[CompilerGenerated]
		internal get { } //Length: 88
	}

	private static AffordanceStateShortcuts() { }

	[CompilerGenerated]
	public static AffordanceStateData get_activatedState() { }

	[CompilerGenerated]
	public static AffordanceStateData get_disabledState() { }

	[CompilerGenerated]
	public static AffordanceStateData get_focusedState() { }

	[CompilerGenerated]
	public static AffordanceStateData get_hoveredPriorityState() { }

	[CompilerGenerated]
	public static AffordanceStateData get_hoveredState() { }

	[CompilerGenerated]
	public static AffordanceStateData get_idleState() { }

	[CompilerGenerated]
	public static AffordanceStateData get_selectedState() { }

	[CompilerGenerated]
	internal static byte get_stateCount() { }

	internal static string GetNameForIndex(byte index) { }

}

