namespace UnityEngine.XR.Interaction.Toolkit;

public interface IXRFilterList
{

	public int count
	{
		 get { } //Length: 0
	}

	public void Add(T item) { }

	public void Clear() { }

	public int get_count() { }

	public void GetAll(List<T> results) { }

	public T GetAt(int index) { }

	public void MoveTo(T item, int newIndex) { }

	public bool Remove(T item) { }

}

