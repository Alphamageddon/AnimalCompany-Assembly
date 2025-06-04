namespace UnityEngine.XR.Interaction.Toolkit;

public struct InteractionLayerMask : ISerializationCallbackReceiver
{
	[SerializeField]
	private uint m_Bits; //Field offset: 0x0
	private int m_Mask; //Field offset: 0x4

	public int value
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public int get_value() { }

	public static int GetMask(String[] layerNames) { }

	public static string LayerToName(int layer) { }

	public static int NameToLayer(string layerName) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	public static int op_Implicit(InteractionLayerMask mask) { }

	public static InteractionLayerMask op_Implicit(int intVal) { }

	public void set_value(int value) { }

}

