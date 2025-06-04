namespace Unity.XR.CoreUtils.Datums;

public abstract class Datum : ScriptableObject
{
	[Multiline]
	[SerializeField]
	private string m_Comments; //Field offset: 0x0
	[SerializeField]
	private bool m_ReadOnly; //Field offset: 0x0
	[SerializeField]
	private T m_Value; //Field offset: 0x0
	private readonly BindableVariableAlloc<T> m_BindableVariableReference; //Field offset: 0x0

	public IReadOnlyBindableVariable<T> BindableVariableReference
	{
		 get { } //Length: 8
	}

	public string Comments
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool ReadOnly
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public T Value
	{
		 get { } //Length: 8
		 set { } //Length: 208
	}

	protected Datum`1() { }

	public IReadOnlyBindableVariable<T> get_BindableVariableReference() { }

	public string get_Comments() { }

	public bool get_ReadOnly() { }

	public T get_Value() { }

	protected void OnEnable() { }

	public void set_Comments(string value) { }

	public void set_ReadOnly(bool value) { }

	public void set_Value(T value) { }

}

