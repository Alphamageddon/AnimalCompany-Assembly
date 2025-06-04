namespace Fusion;

public struct AtomicInt
{
	private int _value; //Field offset: 0x0

	public int Value
	{
		 get { } //Length: 28
	}

	public AtomicInt(int value) { }

	public int CompareExchange(int value, int assumed) { }

	public int Decrement() { }

	public int Exchange(int value) { }

	public int get_Value() { }

	public int IncrementPost() { }

	public int IncrementPre() { }

}

