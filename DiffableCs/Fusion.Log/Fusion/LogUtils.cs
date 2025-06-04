namespace Fusion;

public static class LogUtils
{
	[IsReadOnly]
	internal struct DumpDeferredStruct
	{
		public readonly T Obj; //Field offset: 0x0

		public DumpDeferredStruct`1(T obj) { }

		public virtual string ToString() { }

	}

	[IsReadOnly]
	internal struct DumpDefferedClass
	{
		public readonly ILogDumpable Obj; //Field offset: 0x0

		public DumpDefferedClass(ILogDumpable obj) { }

		public virtual string ToString() { }

	}

	[IsReadOnly]
	internal struct DumpDefferedPtr
	{
		public readonly T* Ptr; //Field offset: 0x0

		public DumpDefferedPtr`1(T* ptr) { }

		public virtual string ToString() { }

	}


	public static DumpDefferedPtr<T> GetDump(T* ptr) { }

	public static DumpDefferedClass GetDump(T obj) { }

}

