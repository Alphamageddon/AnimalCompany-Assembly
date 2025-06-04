namespace Fusion;

internal static class ArraySpecialized
{
	private const int IntrosortSizeThreshold = 16; //Field offset: 0x0

	private static int Compare(SimulationInput x, SimulationInput y) { }

	private static int Compare(int x, int y) { }

	private static void DownHeap(Int32[] array, int i, int n, int lo) { }

	private static void DownHeap(SimulationInput[] array, int i, int n, int lo) { }

	private static int FloorLog2(int n) { }

	private static void Heapsort(Int32[] array, int lo, int hi) { }

	private static void Heapsort(SimulationInput[] array, int lo, int hi) { }

	private static void InsertionSort(Int32[] array, int lo, int hi) { }

	private static void InsertionSort(SimulationInput[] array, int lo, int hi) { }

	private static void IntroSort(Int32[] array, int lo, int hi, int depthLimit) { }

	private static void IntroSort(SimulationInput[] array, int lo, int hi, int depthLimit) { }

	private static int PickPivotAndPartition(Int32[] array, int lo, int hi) { }

	private static int PickPivotAndPartition(SimulationInput[] array, int lo, int hi) { }

	public static void Sort(Int32[] array, int index, int length) { }

	public static void Sort(SimulationInput[] array, int index, int length) { }

	private static void Swap(T[] a, int i, int j) { }

	private static void SwapIfGreater(SimulationInput[] array, int a, int b) { }

	private static void SwapIfGreater(Int32[] array, int a, int b) { }

}

