namespace UnityEngine.InputSystem.Composites;

[DisplayName("Binding With One Modifier")]
[DisplayStringFormat("{modifier}+{binding}")]
public class OneModifierComposite : InputBindingComposite
{
	[InputControl(layout = "Button")]
	public int modifier; //Field offset: 0x10
	[InputControl]
	public int binding; //Field offset: 0x14
	public bool overrideModifiersNeedToBePressedFirst; //Field offset: 0x18
	private int m_ValueSizeInBytes; //Field offset: 0x1C
	private Type m_ValueType; //Field offset: 0x20
	private bool m_BindingIsButton; //Field offset: 0x28

	public virtual int valueSizeInBytes
	{
		 get { } //Length: 8
	}

	public virtual Type valueType
	{
		 get { } //Length: 8
	}

	public OneModifierComposite() { }

	internal static void DetermineValueTypeAndSize(ref InputBindingCompositeContext context, int part, out Type valueType, out int valueSizeInBytes, out bool isButton) { }

	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	protected virtual void FinishSetup(ref InputBindingCompositeContext context) { }

	public virtual int get_valueSizeInBytes() { }

	public virtual Type get_valueType() { }

	private bool ModifierIsPressed(ref InputBindingCompositeContext context) { }

	public virtual void ReadValue(ref InputBindingCompositeContext context, Void* buffer, int bufferSize) { }

	public virtual object ReadValueAsObject(ref InputBindingCompositeContext context) { }

}

