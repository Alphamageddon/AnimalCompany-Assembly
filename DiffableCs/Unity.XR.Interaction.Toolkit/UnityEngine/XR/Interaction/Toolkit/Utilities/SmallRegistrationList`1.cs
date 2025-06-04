namespace UnityEngine.XR.Interaction.Toolkit.Utilities;

internal class SmallRegistrationList : BaseRegistrationList<T>
{
	private bool m_BufferChanges; //Field offset: 0x0

	public bool bufferChanges
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public SmallRegistrationList`1() { }

	public virtual void Flush() { }

	public bool get_bufferChanges() { }

	public virtual T GetRegisteredItemAt(int index) { }

	public virtual void GetRegisteredItems(List<T> results) { }

	public virtual bool IsRegistered(T item) { }

	public virtual bool IsStillRegistered(T item) { }

	public virtual bool Register(T item) { }

	public void set_bufferChanges(bool value) { }

	public virtual bool Unregister(T item) { }

}

