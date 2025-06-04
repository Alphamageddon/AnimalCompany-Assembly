namespace UnityEngine.Animations.Rigging;

[AddComponentMenu("Animation Rigging/Setup/Rig")]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.2/manual/RiggingWorkflow.html#rig-component")]
public class Rig : MonoBehaviour, IRigEffectorHolder
{
	[Range(0, 1)]
	[SerializeField]
	private float m_Weight; //Field offset: 0x20
	[SerializeField]
	private List<RigEffectorData> m_Effectors; //Field offset: 0x28

	public float weight
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public Rig() { }

	public float get_weight() { }

	public void set_weight(float value) { }

}

