namespace Photon.Voice;

public abstract class ObjectPool : IDisposable
{
	protected int capacity; //Field offset: 0x0
	protected TInfo info; //Field offset: 0x0
	private TType[] freeObj; //Field offset: 0x0
	protected int pos; //Field offset: 0x0
	protected string name; //Field offset: 0x0
	private bool inited; //Field offset: 0x0

	public TInfo Info
	{
		 get { } //Length: 24
	}

	internal string LogPrefix
	{
		internal get { } //Length: 108
	}

	public ObjectPool`2(int capacity, string name) { }

	public ObjectPool`2(int capacity, string name, TInfo info) { }

	public TType AcquireOrCreate() { }

	public TType AcquireOrCreate(TInfo info) { }

	protected abstract TType createObject(TInfo info) { }

	protected abstract void destroyObject(TType obj) { }

	public override void Dispose() { }

	public TInfo get_Info() { }

	internal string get_LogPrefix() { }

	protected abstract bool infosMatch(TInfo i0, TInfo i1) { }

	public void Init(TInfo info) { }

	public override bool Release(TType obj, TInfo objInfo) { }

	public override bool Release(TType obj) { }

}

