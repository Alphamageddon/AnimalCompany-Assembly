namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Composites;

[Preserve]
public class Vector3FallbackComposite : FallbackComposite<Vector3>
{
	[InputControl(layout = "Vector3")]
	public int first; //Field offset: 0x10
	[InputControl(layout = "Vector3")]
	public int second; //Field offset: 0x14
	[InputControl(layout = "Vector3")]
	public int third; //Field offset: 0x18

	[Preserve]
	private static Vector3FallbackComposite() { }

	public Vector3FallbackComposite() { }

	[Preserve]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void Initialize() { }

	public virtual Vector3 ReadValue(ref InputBindingCompositeContext context) { }

}

