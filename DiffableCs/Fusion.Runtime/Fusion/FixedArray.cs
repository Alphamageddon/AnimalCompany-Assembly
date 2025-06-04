namespace Fusion;

[Extension]
public static class FixedArray
{

	public static FixedArray<T> Create(ref T firstField, int length) { }

	public static FixedArray<TAdapted> Create(ref TActual firstField, int length) { }

	public static FixedArray<T> CreateFromFieldSequence(ref T firstField, ref T lastField) { }

	[Extension]
	public static int IndexOf(FixedArray<T> array, T elem) { }

}

