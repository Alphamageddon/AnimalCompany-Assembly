namespace MagicLightProbes;

[HelpURL("https://motion-games-studio.gitbook.io/magic-light-probes/system-components/mlp-quick-editing")]
public class MLPQuickEditing : MonoBehaviour
{
	public MagicLightProbes parent; //Field offset: 0x20
	public float gizmoScale; //Field offset: 0x28
	public float drawDistance; //Field offset: 0x2C
	private Vector3 _lastPrefabPosition; //Field offset: 0x30
	private Quaternion _lastPrefabRotation; //Field offset: 0x3C

	public MLPQuickEditing() { }

}

