namespace UnityEngine.XR.Interaction.Toolkit.Inputs;

[AddComponentMenu("Input/Input Action Manager")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.Inputs.InputActionManager.html")]
public class InputActionManager : MonoBehaviour
{
	[SerializeField]
	[Tooltip("Input action assets to affect when inputs are enabled or disabled.")]
	private List<InputActionAsset> m_ActionAssets; //Field offset: 0x20

	public List<InputActionAsset> actionAssets
	{
		 get { } //Length: 8
		 set { } //Length: 108
	}

	public InputActionManager() { }

	public void DisableInput() { }

	public void EnableInput() { }

	public List<InputActionAsset> get_actionAssets() { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	public void set_actionAssets(List<InputActionAsset> value) { }

}

