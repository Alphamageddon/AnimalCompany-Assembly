namespace UnityEngine.InputSystem;

public class InputActionReference : ScriptableObject
{
	[SerializeField]
	internal InputActionAsset m_Asset; //Field offset: 0x18
	[SerializeField]
	internal string m_ActionId; //Field offset: 0x20
	private InputAction m_Action; //Field offset: 0x28

	public InputAction action
	{
		 get { } //Length: 172
	}

	public InputActionAsset asset
	{
		 get { } //Length: 8
	}

	public InputActionReference() { }

	public static InputActionReference Create(InputAction action) { }

	public InputAction get_action() { }

	public InputActionAsset get_asset() { }

	private static string GetDisplayName(InputAction action) { }

	public static InputAction op_Implicit(InputActionReference reference) { }

	public void Set(InputAction action) { }

	public void Set(InputActionAsset asset, string mapName, string actionName) { }

	private void SetInternal(InputActionAsset asset, InputAction action) { }

	internal string ToDisplayName() { }

	public InputAction ToInputAction() { }

	public virtual string ToString() { }

}

