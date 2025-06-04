namespace UnityEngine.XR.Interaction.Toolkit.Utilities;

internal class ExposedRegistrationList : SmallRegistrationList<T>, IXRFilterList<T>
{

	public override int count
	{
		 get { } //Length: 32
	}

	public ExposedRegistrationList`1() { }

	public override void Add(T item) { }

	public override void Clear() { }

	public override int get_count() { }

	public override void GetAll(List<T> results) { }

	public override T GetAt(int index) { }

	public override void MoveTo(T item, int newIndex) { }

	public void RegisterReferences(List<TObject> references, object context = null) { }

	public override bool Remove(T item) { }

}

