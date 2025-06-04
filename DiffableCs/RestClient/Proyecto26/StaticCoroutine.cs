namespace Proyecto26;

public static class StaticCoroutine
{
	private class CoroutineHolder : MonoBehaviour
	{

		public CoroutineHolder() { }

	}

	private static CoroutineHolder _runner; //Field offset: 0x0

	private static CoroutineHolder runner
	{
		private get { } //Length: 344
	}

	private static CoroutineHolder get_runner() { }

	public static Coroutine StartCoroutine(IEnumerator coroutine) { }

}

