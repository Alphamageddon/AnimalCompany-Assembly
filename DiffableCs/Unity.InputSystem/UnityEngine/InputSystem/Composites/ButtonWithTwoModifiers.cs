namespace UnityEngine.InputSystem.Composites;

[DesignTimeVisible(False)]
[DisplayStringFormat("{modifier1}+{modifier2}+{button}")]
public class ButtonWithTwoModifiers : InputBindingComposite<Single>
{
	[InputControl(layout = "Button")]
	public int modifier1; //Field offset: 0x10
	[InputControl(layout = "Button")]
	public int modifier2; //Field offset: 0x14
	[InputControl(layout = "Button")]
	public int button; //Field offset: 0x18
	public bool overrideModifiersNeedToBePressedFirst; //Field offset: 0x1C

	public ButtonWithTwoModifiers() { }

	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	protected virtual void FinishSetup(ref InputBindingCompositeContext context) { }

	private bool ModifiersArePressed(ref InputBindingCompositeContext context) { }

	public virtual float ReadValue(ref InputBindingCompositeContext context) { }

}

