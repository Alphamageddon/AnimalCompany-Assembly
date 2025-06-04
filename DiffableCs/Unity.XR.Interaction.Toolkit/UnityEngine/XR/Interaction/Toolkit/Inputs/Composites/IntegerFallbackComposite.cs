namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Composites;

[Preserve]
public class IntegerFallbackComposite : FallbackComposite<Int32>
{
	[InputControl(layout = "Integer")]
	public int first; //Field offset: 0x10
	[InputControl(layout = "Integer")]
	public int second; //Field offset: 0x14
	[InputControl(layout = "Integer")]
	public int third; //Field offset: 0x18

	[Preserve]
	private static IntegerFallbackComposite() { }

	public IntegerFallbackComposite() { }

	[Preserve]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void Initialize() { }

	public virtual int ReadValue(ref InputBindingCompositeContext context) { }

}

