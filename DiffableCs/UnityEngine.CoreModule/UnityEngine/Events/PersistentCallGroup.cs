namespace UnityEngine.Events;

internal class PersistentCallGroup
{
	[FormerlySerializedAs("m_Listeners")]
	[SerializeField]
	private List<PersistentCall> m_Calls; //Field offset: 0x10

	public int Count
	{
		 get { } //Length: 72
	}

	public PersistentCallGroup() { }

	public int get_Count() { }

	public void Initialize(InvokableCallList invokableList, UnityEventBase unityEventBase) { }

}

