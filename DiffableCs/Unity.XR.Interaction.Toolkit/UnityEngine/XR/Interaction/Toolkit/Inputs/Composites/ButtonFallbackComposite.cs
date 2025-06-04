namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Composites;

[Preserve]
public class ButtonFallbackComposite : FallbackComposite<Single>
{
	[InputControl(layout = "Button")]
	public int first; //Field offset: 0x10
	[InputControl(layout = "Button")]
	public int second; //Field offset: 0x14
	[InputControl(layout = "Button")]
	public int third; //Field offset: 0x18

	[Preserve]
	private static ButtonFallbackComposite() { }

	public ButtonFallbackComposite() { }

	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	[Preserve]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void Initialize() { }

	public virtual float ReadValue(ref InputBindingCompositeContext context) { }

}

