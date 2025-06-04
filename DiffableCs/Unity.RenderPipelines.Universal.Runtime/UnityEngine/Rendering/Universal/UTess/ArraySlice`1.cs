namespace UnityEngine.Rendering.Universal.UTess;

[DebuggerDisplay("Length = {Length}")]
[DebuggerTypeProxy(typeof(ArraySliceDebugView`1))]
[DefaultMember("Item")]
internal struct ArraySlice : IEquatable<ArraySlice`1<T>>
{
	[NativeDisableUnsafePtrRestriction]
	internal Byte* m_Buffer; //Field offset: 0x0
	internal int m_Stride; //Field offset: 0x0
	internal int m_Length; //Field offset: 0x0

	public T Item
	{
		 get { } //Length: 64
		[WriteAccessRequired]
		 set { } //Length: 76
	}

	public int Length
	{
		 get { } //Length: 8
	}

	public int Stride
	{
		 get { } //Length: 8
	}

	public ArraySlice`1(NativeArray<T> array, int start, int length) { }

	public static ArraySlice<T> ConvertExistingDataToArraySlice(Void* dataPointer, int stride, int length) { }

	internal void CopyTo(T[] array) { }

	public override bool Equals(ArraySlice<T> other) { }

	public virtual bool Equals(object obj) { }

	public T get_Item(int index) { }

	public int get_Length() { }

	public int get_Stride() { }

	public virtual int GetHashCode() { }

	internal Void* GetUnsafeReadOnlyPtr() { }

	public static bool op_Equality(ArraySlice<T> left, ArraySlice<T> right) { }

	public static bool op_Inequality(ArraySlice<T> left, ArraySlice<T> right) { }

	[WriteAccessRequired]
	public void set_Item(int index, T value) { }

	internal T[] ToArray() { }

}

