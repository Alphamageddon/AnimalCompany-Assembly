namespace UnityEngine.Animations.Rigging;

public struct Vector3IntProperty : IAnimatableProperty<Vector3Int>
{
	public PropertyStreamHandle x; //Field offset: 0x0
	public PropertyStreamHandle y; //Field offset: 0x10
	public PropertyStreamHandle z; //Field offset: 0x20

	public static Vector3IntProperty Bind(Animator animator, Component component, string name) { }

	public static Vector3IntProperty BindCustom(Animator animator, string name) { }

	public override Vector3Int Get(AnimationStream stream) { }

	public override void Set(AnimationStream stream, Vector3Int value) { }

}

