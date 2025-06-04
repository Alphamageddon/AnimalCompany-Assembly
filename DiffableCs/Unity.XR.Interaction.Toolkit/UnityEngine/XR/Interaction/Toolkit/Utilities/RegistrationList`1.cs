namespace UnityEngine.XR.Interaction.Toolkit.Utilities;

internal class RegistrationList : BaseRegistrationList<T>
{
	private readonly HashSet<T> m_UnorderedBufferedAdd; //Field offset: 0x0
	private readonly HashSet<T> m_UnorderedBufferedRemove; //Field offset: 0x0
	private readonly HashSet<T> m_UnorderedRegisteredSnapshot; //Field offset: 0x0
	private readonly HashSet<T> m_UnorderedRegisteredItems; //Field offset: 0x0

	public RegistrationList`1() { }

	public virtual void Flush() { }

	public virtual T GetRegisteredItemAt(int index) { }

	public virtual void GetRegisteredItems(List<T> results) { }

	public virtual bool IsRegistered(T item) { }

	public virtual bool IsStillRegistered(T item) { }

	protected virtual void OnItemMovedImmediately(T item, int newIndex) { }

	public virtual bool Register(T item) { }

	public virtual bool Unregister(T item) { }

}

