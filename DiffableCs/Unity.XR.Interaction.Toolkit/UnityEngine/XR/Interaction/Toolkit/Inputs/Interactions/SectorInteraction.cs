namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions;

[Preserve]
public class SectorInteraction : IInputInteraction<Vector2>, IInputInteraction
{
	[Flags]
	internal enum Directions
	{
		None = 0,
		North = 1,
		South = 2,
		East = 4,
		West = 8,
	}

	private enum State
	{
		Centered = 0,
		StartedValidDirection = 1,
		StartedInvalidDirection = 2,
	}

	internal enum SweepBehavior
	{
		Locked = 0,
		AllowReentry = 1,
		DisallowReentry = 2,
		HistoryIndependent = 3,
	}

	[CompilerGenerated]
	private static float <defaultPressPoint>k__BackingField; //Field offset: 0x0
	public Directions directions; //Field offset: 0x10
	public SweepBehavior sweepBehavior; //Field offset: 0x14
	public float pressPoint; //Field offset: 0x18
	private State m_State; //Field offset: 0x1C
	private bool m_WasValidDirection; //Field offset: 0x20

	public static float defaultPressPoint
	{
		[CompilerGenerated]
		 get { } //Length: 88
		[CompilerGenerated]
		 set { } //Length: 100
	}

	internal float pressPointOrDefault
	{
		internal get { } //Length: 152
	}

	[Preserve]
	private static SectorInteraction() { }

	public SectorInteraction() { }

	[CompilerGenerated]
	public static float get_defaultPressPoint() { }

	internal float get_pressPointOrDefault() { }

	private static Directions GetNearestDirection(Cardinal value) { }

	[Preserve]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void Initialize() { }

	private bool IsValidDirection(ref InputInteractionContext context) { }

	public override void Process(ref InputInteractionContext context) { }

	public override void Reset() { }

	[CompilerGenerated]
	public static void set_defaultPressPoint(float value) { }

}

