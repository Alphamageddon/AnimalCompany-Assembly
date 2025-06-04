namespace UnityEngine.ProBuilder;

public sealed class WingedEdgeEnumerator : IEnumerator<WingedEdge>, IEnumerator, IDisposable
{
	private WingedEdge m_Start; //Field offset: 0x10
	private WingedEdge m_Current; //Field offset: 0x18

	public override WingedEdge Current
	{
		 get { } //Length: 8
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 8
	}

	public WingedEdgeEnumerator(WingedEdge start) { }

	public override void Dispose() { }

	public override WingedEdge get_Current() { }

	public override bool MoveNext() { }

	public override void Reset() { }

	private override object System.Collections.IEnumerator.get_Current() { }

}

