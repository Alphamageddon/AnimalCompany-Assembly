namespace AnimalCompany;

public class RayMeshController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <PlayCoroutine>d__9 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RayMeshController <>4__this; //Field offset: 0x20
		private float <timer>5__2; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <PlayCoroutine>d__9(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static readonly int PROP_DURATION; //Field offset: 0x0
	private static readonly int PROP_DISTANCE; //Field offset: 0x4
	private static readonly int PROP_START_TIME; //Field offset: 0x8
	[SerializeField]
	private Mesh _rayMesh; //Field offset: 0x20
	[SerializeField]
	private Material _rayMaterial; //Field offset: 0x28
	[SerializeField]
	private float _duration; //Field offset: 0x30
	private IEnumerator _playCoroutine; //Field offset: 0x38
	private Matrix4x4[] _rayMatrices; //Field offset: 0x40

	private static RayMeshController() { }

	public RayMeshController() { }

	public void Play(Transform tip, List<Vector3> rayDirections, float shootSpread = 0.07, float rayDistance = 20) { }

	[IteratorStateMachine(typeof(<PlayCoroutine>d__9))]
	private IEnumerator PlayCoroutine() { }

}

