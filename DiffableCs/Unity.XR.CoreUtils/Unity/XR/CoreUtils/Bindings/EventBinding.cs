namespace Unity.XR.CoreUtils.Bindings;

public struct EventBinding : IEventBinding
{
	[CompilerGenerated]
	private Action <BindAction>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Action <UnbindAction>k__BackingField; //Field offset: 0x8
	private bool m_IsBound; //Field offset: 0x10

	public Action BindAction
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override bool IsBound
	{
		 get { } //Length: 8
	}

	public Action UnbindAction
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public EventBinding(Action bindAction, Action unBindAction) { }

	public override void Bind() { }

	public override void ClearBinding() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Action get_BindAction() { }

	public override bool get_IsBound() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Action get_UnbindAction() { }

	[CompilerGenerated]
	public void set_BindAction(Action value) { }

	[CompilerGenerated]
	public void set_UnbindAction(Action value) { }

	public override void Unbind() { }

}

