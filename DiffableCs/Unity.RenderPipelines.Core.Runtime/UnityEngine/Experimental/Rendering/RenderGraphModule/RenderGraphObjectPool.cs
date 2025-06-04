namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

public sealed class RenderGraphObjectPool
{
	private class SharedObjectPool : SharedObjectPoolBase
	{
		private static readonly Lazy<SharedObjectPool`1<T>> s_Instance; //Field offset: 0x0
		private Stack<T> m_Pool; //Field offset: 0x0

		public static SharedObjectPool<T> sharedPool
		{
			 get { } //Length: 152
		}

		private static SharedObjectPool`1() { }

		public SharedObjectPool`1() { }

		private static SharedObjectPool<T> AllocatePool() { }

		protected virtual void Clear() { }

		public T Get() { }

		public static SharedObjectPool<T> get_sharedPool() { }

		public void Release(T value) { }

	}

	private abstract class SharedObjectPoolBase
	{
		protected static List<SharedObjectPoolBase> s_AllocatedPools; //Field offset: 0x0

		private static SharedObjectPoolBase() { }

		protected SharedObjectPoolBase() { }

		protected abstract void Clear() { }

		public static void ClearAll() { }

	}

	private Dictionary<ValueTuple`2<Type, Int32>, Stack`1<Object>> m_ArrayPool; //Field offset: 0x10
	private List<ValueTuple`2<Object, ValueTuple`2<Type, Int32>>> m_AllocatedArrays; //Field offset: 0x18
	private List<MaterialPropertyBlock> m_AllocatedMaterialPropertyBlocks; //Field offset: 0x20

	internal RenderGraphObjectPool() { }

	internal void Cleanup() { }

	internal T Get() { }

	public T[] GetTempArray(int size) { }

	public MaterialPropertyBlock GetTempMaterialPropertyBlock() { }

	internal void Release(T value) { }

	internal void ReleaseAllTempAlloc() { }

}

