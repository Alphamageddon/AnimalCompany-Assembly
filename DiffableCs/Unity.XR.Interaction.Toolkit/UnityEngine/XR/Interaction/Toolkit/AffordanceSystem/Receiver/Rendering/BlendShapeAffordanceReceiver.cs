namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Rendering;

[AddComponentMenu("Affordance System/Receiver/Rendering/Blend Shape Affordance Receiver", 12)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Rendering.BlendShapeAffordanceReceiver.html")]
public class BlendShapeAffordanceReceiver : FloatAffordanceReceiver
{
	[SerializeField]
	[Tooltip("Skinned Mesh Renderer to apply blend shapes animations to.")]
	private SkinnedMeshRenderer m_SkinnedMeshRenderer; //Field offset: 0xA8
	[SerializeField]
	[Tooltip("BlendShape index to animate.")]
	private int m_BlendShapeIndex; //Field offset: 0xB0

	public int blendShapeIndex
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public SkinnedMeshRenderer skinnedMeshRenderer
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public BlendShapeAffordanceReceiver() { }

	public int get_blendShapeIndex() { }

	public SkinnedMeshRenderer get_skinnedMeshRenderer() { }

	protected virtual float GetCurrentValueForCapture() { }

	protected virtual void OnAffordanceValueUpdated(float newValue) { }

	protected virtual void OnEnable() { }

	public void set_blendShapeIndex(int value) { }

	public void set_skinnedMeshRenderer(SkinnedMeshRenderer value) { }

}

