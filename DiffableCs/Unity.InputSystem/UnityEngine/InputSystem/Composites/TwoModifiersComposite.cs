namespace UnityEngine.InputSystem.Composites;

[DisplayName("Binding With Two Modifiers")]
[DisplayStringFormat("{modifier1}+{modifier2}+{binding}")]
public class TwoModifiersComposite : InputBindingComposite
{
	[InputControl(layout = "Button")]
	public int modifier1; //Field offset: 0x10
	[InputControl(layout = "Button")]
	public int modifier2; //Field offset: 0x14
	[InputControl]
	public int binding; //Field offset: 0x18
	public bool overrideModifiersNeedToBePressedFirst; //Field offset: 0x1C
	private int m_ValueSizeInBytes; //Field offset: 0x20
	private Type m_ValueType; //Field offset: 0x28
	private bool m_BindingIsButton; //Field offset: 0x30

	public virtual int valueSizeInBytes
	{
		 get { } //Length: 8
	}

	public virtual Type valueType
	{
		 get { } //Length: 8
	}

	public TwoModifiersComposite() { }

	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	protected virtual void FinishSetup(ref InputBindingCompositeContext context) { }

	public virtual int get_valueSizeInBytes() { }

	public virtual Type get_valueType() { }

	private bool ModifiersArePressed(ref InputBindingCompositeContext context) { }

	public virtual void ReadValue(ref InputBindingCompositeContext context, Void* buffer, int bufferSize) { }

	public virtual object ReadValueAsObject(ref InputBindingCompositeContext context) { }

}

