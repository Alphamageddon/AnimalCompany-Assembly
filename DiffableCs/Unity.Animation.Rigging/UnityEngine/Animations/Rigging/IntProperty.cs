namespace UnityEngine.Animations.Rigging;

public struct IntProperty : IAnimatableProperty<Int32>
{
	public PropertyStreamHandle value; //Field offset: 0x0

	public static IntProperty Bind(Animator animator, Component component, string name) { }

	public static IntProperty BindCustom(Animator animator, string property) { }

	public override int Get(AnimationStream stream) { }

	public override void Set(AnimationStream stream, int v) { }

}

