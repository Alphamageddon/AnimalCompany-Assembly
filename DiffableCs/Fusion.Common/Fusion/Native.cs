namespace Fusion;

public static class Native
{
	public const int ALIGNMENT = 8; //Field offset: 0x0
	public const int CACHE_LINE_SIZE = 64; //Field offset: 0x0

	public static Void* AlignPointer(Void* pointer, int alignment) { }

	public static void ArrayClear(T* ptr, int size) { }

	public static int ArrayCompare(T* ptr1, T* ptr2, int size) { }

	public static void ArrayCopy(Void* source, int sourceIndex, Void* destination, int destinationIndex, int count, int elementStride) { }

	public static int CopyFromArray(Void* destination, T[] source) { }

	public static int CopyToArray(T[] destination, Void* source) { }

	public static T* DoubleArray(T* array, int currentLength) { }

	public static T** DoublePtrArray(T** array, int currentLength) { }

	public static T Empty() { }

	public static Void* Expand(Void* buffer, int currentSize, int newSize) { }

	public static T* ExpandArray(T* array, int currentLength, int newLength) { }

	public static T** ExpandPtrArray(T** array, int currentLength, int newLength) { }

	public static void Free(Void* memory) { }

	public static int GetAlignment() { }

	public static int GetAlignment(int stride) { }

	public static int GetFieldOffset(FieldInfo fi) { }

	public static int GetLengthPrefixedUTF8ByteCount(string str) { }

	public static int GetMaxAlignment(int a, int b, int c, int d) { }

	public static int GetMaxAlignment(int a, int b, int c) { }

	public static int GetMaxAlignment(int a, int b) { }

	public static int GetMaxAlignment(int a, int b, int c, int d, int e) { }

	public static bool IsAligned(int stride, int alignment) { }

	public static bool IsPointerAligned(Void* pointer, int alignment) { }

	public static Void* Malloc(int size) { }

	public static T* Malloc() { }

	public static Void* MallocAndClear(int size) { }

	public static T* MallocAndClear() { }

	public static T* MallocAndClearArray(int length) { }

	public static Void* MallocAndClearArray(int stride, int length) { }

	public static T* MallocAndClearArrayMin1(int length) { }

	public static int MallocAndClearBlock(int size0, int size1, int size2, int size3, int size4, int size5, out Void* ptr0, out Void* ptr1, out Void* ptr2, out Void* ptr3, out Void* ptr4, out Void* ptr5, int alignment = 8) { }

	public static int MallocAndClearBlock(int size0, int size1, int size2, int size3, out Void* ptr0, out Void* ptr1, out Void* ptr2, out Void* ptr3, int alignment = 8) { }

	public static int MallocAndClearBlock(int size0, int size1, int size2, out Void* ptr0, out Void* ptr1, out Void* ptr2, int alignment = 8) { }

	public static int MallocAndClearBlock(int size0, int size1, int size2, int size3, int size4, out Void* ptr0, out Void* ptr1, out Void* ptr2, out Void* ptr3, out Void* ptr4, int alignment = 8) { }

	public static int MallocAndClearBlock(int size0, int size1, int size2, int size3, int size4, int size5, int size6, int size7, int size8, int size9, int size10, int size11, out Void* ptr0, out Void* ptr1, out Void* ptr2, out Void* ptr3, out Void* ptr4, out Void* ptr5, out Void* ptr6, out Void* ptr7, out Void* ptr8, out Void* ptr9, out Void* ptr10, out Void* ptr11, int alignment = 8) { }

	public static int MallocAndClearBlock(int size0, int size1, int size2, int size3, int size4, int size5, int size6, int size7, out Void* ptr0, out Void* ptr1, out Void* ptr2, out Void* ptr3, out Void* ptr4, out Void* ptr5, out Void* ptr6, out Void* ptr7, int alignment = 8) { }

	public static int MallocAndClearBlock(int size0, int size1, int size2, int size3, int size4, int size5, int size6, int size7, int size8, out Void* ptr0, out Void* ptr1, out Void* ptr2, out Void* ptr3, out Void* ptr4, out Void* ptr5, out Void* ptr6, out Void* ptr7, out Void* ptr8, int alignment = 8) { }

	public static int MallocAndClearBlock(int size0, int size1, int size2, int size3, int size4, int size5, int size6, int size7, int size8, int size9, int size10, out Void* ptr0, out Void* ptr1, out Void* ptr2, out Void* ptr3, out Void* ptr4, out Void* ptr5, out Void* ptr6, out Void* ptr7, out Void* ptr8, out Void* ptr9, out Void* ptr10, int alignment = 8) { }

	public static int MallocAndClearBlock(int size0, int size1, int size2, int size3, int size4, int size5, int size6, int size7, int size8, int size9, out Void* ptr0, out Void* ptr1, out Void* ptr2, out Void* ptr3, out Void* ptr4, out Void* ptr5, out Void* ptr6, out Void* ptr7, out Void* ptr8, out Void* ptr9, int alignment = 8) { }

	public static int MallocAndClearBlock(int size0, int size1, int size2, int size3, int size4, int size5, int size6, out Void* ptr0, out Void* ptr1, out Void* ptr2, out Void* ptr3, out Void* ptr4, out Void* ptr5, out Void* ptr6, int alignment = 8) { }

	public static int MallocAndClearBlock(int size0, int size1, out Void* ptr0, out Void* ptr1, int alignment = 8) { }

	public static T** MallocAndClearPtrArray(int length) { }

	public static T** MallocAndClearPtrArrayMin1(int length) { }

	public static void MemClear(Void* ptr, int size) { }

	public static int MemCmp(Void* ptr1, Void* ptr2, int size) { }

	public static void MemCpy(Void* destination, Void* source, int size) { }

	public static void MemCpyFast(Void* d, Void* s, int size) { }

	public static void MemMove(Void* destination, Void* source, int size) { }

	public static int ReadLengthPrefixedUTF8(Void* source, out string result) { }

	public static Byte* ReferenceToPointer(ref T obj) { }

	public static int RoundBitsUpTo32(int bits) { }

	public static int RoundBitsUpTo64(int bits) { }

	public static long RoundToAlignment(long stride, int alignment) { }

	public static int RoundToAlignment(int stride, int alignment) { }

	public static int RoundToMaxAlignment(int stride) { }

	public static int SizeOf(Type t) { }

	public static int WordCount(int stride, int wordSize) { }

	public static int WriteLengthPrefixedUTF8(Void* destination, string str) { }

}

