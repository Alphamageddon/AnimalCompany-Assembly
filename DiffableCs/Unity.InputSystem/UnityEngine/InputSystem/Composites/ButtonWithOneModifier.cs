namespace UnityEngine.InputSystem.Composites;

[DesignTimeVisible(False)]
[DisplayStringFormat("{modifier}+{button}")]
public class ButtonWithOneModifier : InputBindingComposite<Single>
{
	[InputControl(layout = "Button")]
	public int modifier; //Field offset: 0x10
	[InputControl(layout = "Button")]
	public int button; //Field offset: 0x14
	public bool overrideModifiersNeedToBePressedFirst; //Field offset: 0x18

	public ButtonWithOneModifier() { }

	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	protected virtual void FinishSetup(ref InputBindingCompositeContext context) { }

	private bool ModifierIsPressed(ref InputBindingCompositeContext context) { }

	public virtual float ReadValue(ref InputBindingCompositeContext context) { }

}

