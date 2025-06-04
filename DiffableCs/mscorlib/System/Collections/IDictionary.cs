namespace System.Collections;

[DefaultMember("Item")]
public interface IDictionary : ICollection, IEnumerable
{

	public object Item
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public ICollection Keys
	{
		 get { } //Length: 0
	}

	public ICollection Values
	{
		 get { } //Length: 0
	}

	public void Add(object key, object value) { }

	public bool Contains(object key) { }

	public object get_Item(object key) { }

	public ICollection get_Keys() { }

	public ICollection get_Values() { }

	public IDictionaryEnumerator GetEnumerator() { }

	public void Remove(object key) { }

	public void set_Item(object key, object value) { }

}

