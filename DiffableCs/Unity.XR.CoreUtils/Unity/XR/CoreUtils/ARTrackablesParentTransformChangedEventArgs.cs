namespace Unity.XR.CoreUtils;

[IsReadOnly]
public struct ARTrackablesParentTransformChangedEventArgs : IEquatable<ARTrackablesParentTransformChangedEventArgs>
{
	[CompilerGenerated]
	private readonly XROrigin <Origin>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly Transform <TrackablesParent>k__BackingField; //Field offset: 0x8

	public XROrigin Origin
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public Transform TrackablesParent
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public ARTrackablesParentTransformChangedEventArgs(XROrigin origin, Transform trackablesParent) { }

	public override bool Equals(ARTrackablesParentTransformChangedEventArgs other) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public XROrigin get_Origin() { }

	[CompilerGenerated]
	public Transform get_TrackablesParent() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(ARTrackablesParentTransformChangedEventArgs lhs, ARTrackablesParentTransformChangedEventArgs rhs) { }

	public static bool op_Inequality(ARTrackablesParentTransformChangedEventArgs lhs, ARTrackablesParentTransformChangedEventArgs rhs) { }

}

