namespace Fusion;

[AddComponentMenu("Fusion/Enable On Single Runner")]
public class EnableOnSingleRunner : Behaviour
{
	private static readonly List<Component> reusableComponentsList; //Field offset: 0x0
	private static readonly List<Component> reusableComponentsList2; //Field offset: 0x8
	[InlineHelp]
	[SerializeField]
	public PreferredRunners PreferredRunner; //Field offset: 0x20
	[InlineHelp]
	public Component[] Components; //Field offset: 0x28
	[HideInInspector]
	[SerializeField]
	private string _guid; //Field offset: 0x30

	private static EnableOnSingleRunner() { }

	public EnableOnSingleRunner() { }

	internal void AddNodes(List<RunnerVisibilityLink> existingNodes) { }

	[EditorButton("Find in Nested Children", EditorButtonVisibility::EditMode (1), 0, True)]
	public void FindNestedRecognizedTypes() { }

	private static Component[] FindRecognizedComponentsOnGameObject(GameObject go) { }

	private static Component[] FindRecognizedNestedComponents(GameObject go) { }

	[EditorButton("Find on GameObject", EditorButtonVisibility::EditMode (1), 0, True)]
	public void FindRecognizedTypes() { }

}

