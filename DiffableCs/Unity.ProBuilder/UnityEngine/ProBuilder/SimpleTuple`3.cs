namespace UnityEngine.ProBuilder;

internal struct SimpleTuple
{
	private T1 m_Item1; //Field offset: 0x0
	private T2 m_Item2; //Field offset: 0x0
	private T3 m_Item3; //Field offset: 0x0

	public T1 item1
	{
		 get { } //Length: 12
		 set { } //Length: 12
	}

	public T2 item2
	{
		 get { } //Length: 12
		 set { } //Length: 12
	}

	public T3 item3
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public SimpleTuple`3(T1 item1, T2 item2, T3 item3) { }

	public T1 get_item1() { }

	public T2 get_item2() { }

	public T3 get_item3() { }

	public void set_item1(T1 value) { }

	public void set_item2(T2 value) { }

	public void set_item3(T3 value) { }

	public virtual string ToString() { }

}

