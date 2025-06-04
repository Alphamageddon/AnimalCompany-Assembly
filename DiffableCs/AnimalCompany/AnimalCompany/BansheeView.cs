namespace AnimalCompany;

public class BansheeView : MobView
{
	[CompilerGenerated]
	private sealed class <AttackingCoroutine>d__10 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public BansheeView <>4__this; //Field offset: 0x20

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
		public <AttackingCoroutine>d__10(int <>1__state) { }

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

	private static readonly Vector2 BLENDSHAPE_RANDOM_RANGE; //Field offset: 0x0
	[Header("Banshee")]
	[SerializeField]
	private SkinnedMeshRenderer[] _renderersBlendShape; //Field offset: 0xB0
	[SerializeField]
	private MeshRenderer _rendererTeeth; //Field offset: 0xB8
	[SerializeField]
	private Collider[] _colliders; //Field offset: 0xC0
	public Transform headLookAtTargetTransform; //Field offset: 0xC8
	private IEnumerator _attackingCoroutine; //Field offset: 0xD0
	private bool _isAttacking; //Field offset: 0xD8

	private static BansheeView() { }

	public BansheeView() { }

	[IteratorStateMachine(typeof(<AttackingCoroutine>d__10))]
	private IEnumerator AttackingCoroutine() { }

	[ContextMenu("GetRenderersAndColliders")]
	public void GetRenderersAndColliders() { }

	public void SetAttacking(bool isAttacking) { }

	public virtual void SetDeath(bool isDie) { }

	public void SetVisible(bool visible) { }

	protected virtual void Update() { }

}

