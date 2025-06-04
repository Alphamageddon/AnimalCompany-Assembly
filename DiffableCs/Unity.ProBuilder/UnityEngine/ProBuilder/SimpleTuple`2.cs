namespace UnityEngine.ProBuilder;

public struct SimpleTuple
{
	private T1 m_Item1; //Field offset: 0x0
	private T2 m_Item2; //Field offset: 0x0

	public T1 item1
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public T2 item2
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public SimpleTuple`2(T1 item1, T2 item2) { }

	public T1 get_item1() { }

	public T2 get_item2() { }

	public void set_item1(T1 value) { }

	public void set_item2(T2 value) { }

	public virtual string ToString() { }

}

