namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Composites;

[Preserve]
public class QuaternionFallbackComposite : FallbackComposite<Quaternion>
{
	[InputControl(layout = "Quaternion")]
	public int first; //Field offset: 0x10
	[InputControl(layout = "Quaternion")]
	public int second; //Field offset: 0x14
	[InputControl(layout = "Quaternion")]
	public int third; //Field offset: 0x18

	[Preserve]
	private static QuaternionFallbackComposite() { }

	public QuaternionFallbackComposite() { }

	[Preserve]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void Initialize() { }

	public virtual Quaternion ReadValue(ref InputBindingCompositeContext context) { }

}

